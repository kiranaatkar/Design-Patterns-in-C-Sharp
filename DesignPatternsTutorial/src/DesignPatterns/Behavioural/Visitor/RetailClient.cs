namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Visitor
{
    public class RetailClient : Client
    {
        public RetailClient(string name, string email) : base(name, email)
        {
        }

        public override void SendEmail()
        {
            Console.WriteLine("Sending email to Retail client: " + _name + " at " + _email);
        }
    }
}