namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.ChainOfResponsibility
{
    // BAD - order of operations is hardcoded
    // if we want to disable one or more of the operations, we have to change the code (O/C principle)
    // Because we use the new keyword to create the objects, we can't easily replace them with other objects
    // (tightly coupled to the concrete classes)
    public class WebServer
    {
        public void Handle(HttpRequest request)
        {
            var validator = new Validator();
            validator.Validate(request);

            var authenticator = new Authenticator();
            authenticator.Authenticate(request);

            var logger = new Logger();
            logger.Log(request);
        }
    }
}