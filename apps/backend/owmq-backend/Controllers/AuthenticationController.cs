using Microsoft.AspNetCore.Mvc;
using owmq_backend.Dto.Authentication;
using owmq_backend.Interfaces;
namespace owmq_backend.Controllers;

[ApiController]
[Route("[controller]")] // route lives at controller name: /authentication
public class AuthenticationController : ControllerBase
{

	private readonly ILogger<AuthenticationController> _logger;
	private readonly IAuthenticationService _service;

	public AuthenticationController(ILogger<AuthenticationController> logger, IAuthenticationService AuthService)
	{
		_logger = logger;
		_service = AuthService;
	}

	[HttpPost("signup")]
	public ActionResult<SignUpOutputDto> signup(SignUpDto signup)
	{
		return _service.SignUp(signup);
	}

	[HttpPost("signin")]
	public ActionResult<SignInOutputDto> signin(SignInDto credentials)
	{
		return _service.SignIn(credentials);
	}
}
