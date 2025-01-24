namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.ChainOfResponsibility.GoodSolution
{
    public abstract class Handler
    {
        private Handler _nextHandler;
        
        public Handler SetNext(Handler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public void Handle(HttpRequest request) 
        {
            Console.WriteLine("Handler: " + this.GetType().Name);
            if (DoHandle(request))
                return;

            if (_nextHandler != null)
                _nextHandler.Handle(request);
        }

        public abstract bool DoHandle(HttpRequest request);
    }
}