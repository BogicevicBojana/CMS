using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Google.Apis.Auth;
using CompanyManagementSystem.API.Utils.Auth;
using static Google.Apis.Auth.GoogleJsonWebSignature;
using CompanyManagementSystem.API.Services.Users;
using CompanyManagementSystem.API.Services.Roles;

namespace CompanyManagementSystem.API.Controllers
{
#pragma warning disable CS8604
    [ApiController]
    [AllowAnonymous, Route("account")]
    public class AccountController : Controller
    {
        // * Once the user is logged in, each subsequent request will include the JWT, allowing the user to access routes, services, and resources that are permitted with that token.

        private readonly IConfiguration configuration;
        private readonly JwtGenerator jwtGenerator;
        private readonly IUserService userService;
        private readonly IRoleService roleService;

        public AccountController(IConfiguration _configuration, IUserService _userService, IRoleService _roleService)
        {
            this.roleService = _roleService;
            this.userService = _userService;
            this.configuration = _configuration;
            this.jwtGenerator = new JwtGenerator(PRIVATE_KEY);
        }

        private const String PRIVATE_KEY = @"MIICXQIBAAKBgQCSWSt4T1v7y4qBfSm4raUwKmWpVv5JBgSu3L4XxWPlYIVvZouW
/YkEHzczdQBUb77aE2hsbWhpQ2mmQvF9YUQqOc11sb7y0JqiEFPDbVNwFgOoFJkk
ezCjHQ6X3VherzxEWe096FS9rO/YXnDZHi4jPzZw7gK6Ca2PKo5UKmuWHwIDAQAB
AoGAOcGHLkvjeVOyrbe/p2qgLooM5O+4GwmM/5WOT8NO0U9uWbCWllgoor/PATfD
kY8oOtg99cyX0DMSltMEiv6/721ITO65NkGSOaNUsNYXbS7ZaAW8px3LrgT4fHRh
/I4Xam6a4upBym7SWVEpBqhWwKuln9ZIKYUj/T7sBzvZtwECQQD0GImnEYhA3lvZ
D6B317/ZaqInQRWgyFFylW/x0z/ll0yXA6Nkd+8/YnqFYKzcnYlnX+pYOCE1S3k6
+PctEpQRAkEAmXxIsiswfhKhsmm1Gp4ZziadQU+yGuoQGHlM2bga6Ct+yeg+Dp/e
LeusNGrrO6bXbI+zhcvdqq2aYYQKUsb3LwJBAOeYpHpsiw+pKhIv3nv2q2N45jNC
cGflyElkehtC6RxISnX6ELwRg2FraX5FNJ35ptX7Tli3oOJ1IqgOck9EklECQFLj
pNrbqj+bzkls/wpV8be8cNaxtI0GdRTShWdbHuTdgIaH7uO1AKcqDIDucQVxEAwn
+xq5w4eGY8ZgKbcUjq8CQQDPz6zOTyrSpDvQWuFHx6y1awruCEAzjTfSh4j2Vqcl
yBwsG0v/NT/uq7q56ZvqhxC9YuTttEFpBQeGBKaBdof1";

        // * This endpoint will be called before calling secured endpoint

        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] AuthenticateRequest authenticateRequest)
        {
            // GoogleJsonWebSignature ValidationSettings
            ValidationSettings settings = new ValidationSettings
            {
                Audience = new List<string>() { "325021082664-8k11bcfrj1fpiakuc3131huntfsaiv12.apps.googleusercontent.com" }
            };

            // Validate incoming JWT and get payload information
            GoogleJsonWebSignature.Payload googlePayload = GoogleJsonWebSignature.ValidateAsync(authenticateRequest.IdToken, settings).Result;

            var email = googlePayload.Email;
            var user = userService.GetUserByEmail(email);

            // ! HANDLE LOGOUT ON FRONT IF 401 IS RETURNED
            if (user == null || user.IsDeleted)
            {
                return Unauthorized(new
                {
                    Code = 401,
                    Message = "Unauthorized",
                    Details = "User is not registered on the system"
                });
            }

            var userId = user.Id.ToString();
            var roleName = roleService.GetRoleNameById(user.RoleId);
            var positionName = user.WorkingPosition.Name;

            // constructing new jwt
            var token = jwtGenerator.GenerateAuthToken(userId, email, roleName, positionName);

            return Ok(token);
        }
    }
}