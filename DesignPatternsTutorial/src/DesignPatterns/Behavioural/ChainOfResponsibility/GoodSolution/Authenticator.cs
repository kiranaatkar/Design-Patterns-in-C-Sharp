namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.ChainOfResponsibility.GoodSolution
{
    public class Authenticator : Handler
    {
        public override bool DoHandle(HttpRequest request)
        {
            var username = request.ValidatedUsername;
            var password = request.ValidatedPassword;

            // authenticate user
            return !(username == "kit" && password == "123");
        }
    }
}