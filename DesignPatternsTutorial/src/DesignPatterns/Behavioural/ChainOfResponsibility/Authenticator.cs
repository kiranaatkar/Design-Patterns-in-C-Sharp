namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.ChainOfResponsibility
{
    public class Authenticator
    {
        public bool Authenticate(HttpRequest request)
        {
            var username = request.ValidatedUsername;
            var password = request.ValidatedPassword;

            // authenticate user
            return username == "kit" && password == "123";
        }
    }
}