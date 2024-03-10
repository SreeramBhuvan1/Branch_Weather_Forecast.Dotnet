namespace Task1.Controllers
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Task1.contracts;
    using Task1.dtos.userdtos;

    
    
        [Route("api/[controller]")]
        [ApiController]
        public class AccountController : ControllerBase
        {
            private readonly IAuthManager authmanager;
            private readonly ILogger<AccountController> _logger;

            public AccountController(IAuthManager authmanager, ILogger<AccountController> logger)
            {
                this.authmanager = authmanager;
                this._logger = logger;
            }
            //api/account/resgister
            [HttpPost]
            [Route("register")]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            [ProducesResponseType(StatusCodes.Status500InternalServerError)]
            [ProducesResponseType(StatusCodes.Status200OK)]
            public async Task<ActionResult> Register([FromBody] ApiUserdto userdto)
            {
                _logger.LogInformation($"Registration Attempt for {userdto.Email}");

                var errors = await authmanager.register(userdto);
                if (errors.Any())
                {
                    foreach (var error in errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                    return BadRequest(ModelState);
                }
                return Ok();




            }

            [HttpPost]
            [Route("login")]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            [ProducesResponseType(StatusCodes.Status500InternalServerError)]
            [ProducesResponseType(StatusCodes.Status200OK)]
            public async Task<ActionResult> login([FromBody] LoginDto loginDto)
            {
                _logger.LogInformation($"login Attempt for {loginDto.Email}");

                var authresponse = await authmanager.login(loginDto);
                if (authresponse == null)
                {
                    return Unauthorized();

                }

                return Ok(authresponse);

            }

            [HttpPost]
            [Route("refreshtoken")]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            [ProducesResponseType(StatusCodes.Status500InternalServerError)]
            [ProducesResponseType(StatusCodes.Status200OK)]
            public async Task<ActionResult> refreshtoken([FromBody] AuthResponse request)
            {
                var authresponse = await authmanager.VerifyRefreshToken(request);
                if (authresponse == null)
                {
                    return Unauthorized();

                }

                return Ok(authresponse);
            }
        }
    }


