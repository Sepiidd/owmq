using owmq_backend.Dto.Authentication;
using owmq_backend.Interfaces;
using owmq_backend.Database;
namespace owmq_backend.Services;

public class AuthenticationService : IAuthenticationService
{
	private readonly owmqDbContext _db;

	public AuthenticationService(owmqDbContext dbContext){
		_db = dbContext;
	}

	//TODO
	public SignUpOutputDto SignUp(SignUpDto signup)
	{
		return new SignUpOutputDto();
	}

	//TODO
	public SignInOutputDto SignIn(SignInDto credentials)
	{
		return new SignInOutputDto();
	}
}
