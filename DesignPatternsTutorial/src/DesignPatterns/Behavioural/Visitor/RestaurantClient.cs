namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Visitor
{
    public class RestaurantClient : Client
    {
        public RestaurantClient(string name, string email) : base(name, email)
        {
        }

        public override void SendEmail()
        {
            Console.WriteLine("Sending email to Restaurant client: " + _name + " at " + _email);
        }
    }
}