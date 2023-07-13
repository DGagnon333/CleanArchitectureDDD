namespace BuberDinner.Application.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResult Register(string firstname, string lastname, string email, string password)
    {
        return new AuthenticationResult(
            Guid.NewGuid(),
            firstname,
            lastname,
            email,
            password
        );
    }

    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(
            Guid.NewGuid(),
            "firstName",
            "lastName",
            email,
            password
        );
    }
}