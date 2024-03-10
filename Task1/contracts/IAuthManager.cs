using Microsoft.AspNetCore.Identity;
using Task1.dtos.userdtos;

namespace Task1.contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> register(ApiUserdto userDto);
        Task<AuthResponse> login(LoginDto logindto);
        Task<string> CreateRefreshToken();
        Task<AuthResponse> VerifyRefreshToken(AuthResponse request);
    }
}
