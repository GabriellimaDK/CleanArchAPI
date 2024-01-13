namespace DinnerHosting.Application.Services.Authentication
{
    public interface IAuthenticationService
    {
        AuthenticationResult Login(string email, string password);
        AuthenticationResult Register(string fisrtName, string lastName, string email, string password);
    }
}
