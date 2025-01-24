namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.ChainOfResponsibility
{
    public class Validator
    {
        public void Validate(HttpRequest request)
        {
            var username = request.GetUsername();
            var password = request.GetPassword();

            // trim whitespace

            request.ValidatedUsername = username.Trim();
            request.ValidatedPassword = password.Trim();
        }
    }
}