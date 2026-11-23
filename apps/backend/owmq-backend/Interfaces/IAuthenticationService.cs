using owmq_backend.Dto.Authentication;
namespace owmq_backend.Interfaces;

public interface IAuthenticationService{
    SignUpOutputDto SignUp(SignUpDto SignupCredentials);
    SignInOutputDto SignIn(SignInDto Credentials);
}
