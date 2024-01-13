namespace DinnerHosting.Application.Services.Authentication
{
    public record AuthenticationResult(
        Guid Id,
        string FisrtName,
        string LastName,
        string Email,
        string Token);
}
