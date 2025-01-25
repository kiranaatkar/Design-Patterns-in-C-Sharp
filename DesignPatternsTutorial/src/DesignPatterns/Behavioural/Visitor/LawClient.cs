namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Visitor
{
    public class LawClient : Client
    {
        public LawClient(string name, string email) : base(name, email)
        {
            
        }

        public override void SendEmail()
        {
            Console.WriteLine("Sending email to Law client: " + _name + " at " + _email);
        }
    }
}