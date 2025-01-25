namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Visitor.GoodSolution
{
    public class RestaurantClient : Client
    {
        public RestaurantClient(string name, string email) : base(name, email)
        {
        }

        public override void Accept(Visitor visitor)
        {
            visitor.VisitRestaurant(this);
        }
    }
}