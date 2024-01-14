using DinnerHosting.Application.Common.Interfaces.Authentication;

namespace DinnerHosting.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
        {
                _jwtTokenGenerator = jwtTokenGenerator;
        }

        public AuthenticationResult Login(string email, string password)
        {
            return new AuthenticationResult(
                Guid.NewGuid(),
                string.Empty, 
                string.Empty, 
                email, 
                "token");
        }

        public AuthenticationResult Register(string firstName, string lastName, string email, string password)
        {
            //check if user already exists

            //create user (generate unique ID)
            Guid userId = Guid.NewGuid();
            //create JWT token
            var token = _jwtTokenGenerator.GenerateToken(userId, firstName, lastName);
      
            return new AuthenticationResult(
                userId, 
                firstName, 
                lastName, 
                email, 
                token);       
        }
    }
}
