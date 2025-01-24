namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.ChainOfResponsibility.GoodSolution
{
    public class Validator : Handler
    {
        public override bool DoHandle(HttpRequest request)
        {
            var username = request.GetUsername();
            var password = request.GetPassword();

            // trim whitespace
            request.ValidatedUsername = username.Trim();
            request.ValidatedPassword = password.Trim();
            
            return request.ValidatedUsername == "" || request.ValidatedPassword == "";
        }
    }
}