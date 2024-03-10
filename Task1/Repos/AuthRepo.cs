using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Task1.contracts;
using Task1.Data;
using Task1.dtos.userdtos;

namespace Task1.Repos
{
    public class AuthRepo : IAuthManager
    {
        private readonly IMapper _mapper;
        private readonly ILogger<AuthRepo> _logger;
        private readonly IConfiguration _config;
        private readonly UserManager<ApiUser> _userManager;
        private ApiUser _user;
        private const string _loginProvider = "Task1API";
        private const string _refreshToken = "RefreshToken";
        public AuthRepo(IMapper mapper, UserManager<ApiUser> userManager, IConfiguration config, ILogger<AuthRepo> logger)
        {
            this._mapper = mapper;
            this._userManager = userManager;
            this._config = config;
            this._logger = logger;
        }
        public async Task<string> CreateRefreshToken()
        {
            await _userManager.RemoveAuthenticationTokenAsync(_user, _loginProvider, _refreshToken);
            var newrefreshToken = await _userManager.GenerateUserTokenAsync(_user, _loginProvider, _refreshToken);
            var result = await _userManager.SetAuthenticationTokenAsync(_user, _loginProvider, _refreshToken, newrefreshToken);
            return newrefreshToken;
        }
        public async Task<AuthResponse> login(LoginDto logindto)
        {
            _logger.LogInformation($"searching user{logindto.Email}");
            _user = await _userManager.FindByEmailAsync(logindto.Email);
            bool isValiduser = await _userManager.CheckPasswordAsync(_user, logindto.Password);

            if (_user == null || isValiduser == false)
            {
                return null;
            }


            var token = await GenerateToken();
            return new AuthResponse
            {
                Token = token,
                UserId = _user.Id,
                RefreshToken = await CreateRefreshToken()
            };
        }

        public async Task<IEnumerable<IdentityError>> register(ApiUserdto userDto)
        {
            var user = _mapper.Map<ApiUser>(userDto);
            user.UserName = userDto.Email;
            var result = await _userManager.CreateAsync(user, userDto.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "User");
            }
            return result.Errors;
        }
        public async Task<AuthResponse> VerifyRefreshToken(AuthResponse request)
        {
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var tokenContent = jwtSecurityTokenHandler.ReadJwtToken(request.Token);
            var username = tokenContent.Claims.ToList().FirstOrDefault(q => q.Type == JwtRegisteredClaimNames.Email).Value;
            _user = await _userManager.FindByNameAsync(username);
            if (_user == null || _user.Id != request.UserId)
            {
                return null;
            }
            var isValidRefreshToken = await _userManager.VerifyUserTokenAsync(_user, _loginProvider, _refreshToken, request.RefreshToken);
            if (isValidRefreshToken)
            {
                var token = await GenerateToken();
                return new AuthResponse
                {
                    Token = token,
                    UserId = _user.Id,
                    RefreshToken = await CreateRefreshToken()
                };
            }
            await _userManager.UpdateSecurityStampAsync(_user);
            return null;
        }
        private async Task<string> GenerateToken()
        {
            var securitykey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JwtSettings:Key"]));
            var credentials = new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha256);
            var roles = await _userManager.GetRolesAsync(_user);
            var roleClaims = roles.Select(x => new Claim(ClaimTypes.Role, x)).ToList();
            var userClaims = await _userManager.GetClaimsAsync(_user);
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub,_user.Email),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email,_user.Email),
                new Claim("Uid",_user.Id),

            }.Union(userClaims).Union(roleClaims);
            var token = new JwtSecurityToken(
                issuer: _config["JwtSettings:Issuer"],
                audience: _config["JwtSettings:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToInt32(_config["JwtSettings:DurationInMinutes"])),
                signingCredentials: credentials
                );
            return new JwtSecurityTokenHandler().WriteToken(token);

        }
    }
}
