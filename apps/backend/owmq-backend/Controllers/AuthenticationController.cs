using Microsoft.AspNetCore.Mvc;
using owmq_backend.Dto.Authentication;
using owmq_backend.Services.Authentication;
namespace owmq_backend.Controllers;

[ApiController]
[Route("[controller]")] // route lives at /authentication
public class AuthenticationController : ControllerBase{


	private readonly ILogger<AuthenticationController> _logger;

	public AuthenticationController(ILogger<AuthenticationController> logger){
		_logger = logger;
	}

	[HttpPost("signup")]
	public ActionResult<SignUpOutputDto> signup(SignUpInputDto signup){
		return AuthenticationService.SignUp(signup);
	}
		
	[HttpPost("signin")]
	public ActionResult<SignInOutputDto> signin(SignInInputDto credentials){
		return AuthenticationService.SignIn(credentials);
	}
}
