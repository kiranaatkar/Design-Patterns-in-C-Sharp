namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Visitor.GoodSolution
{
    public class EmailVisitor : Visitor
    {
        public void VisitLaw(LawClient lawClient)
        {
            Console.WriteLine($"Sending email to law client {lawClient.GetEmail()}");
        }

        public void VisitRestaurant(RestaurantClient financeClient)
        {
            Console.WriteLine($"Sending email to restaurant client {financeClient.GetEmail()}");
        }

        public void VisitRetail(RetailClient retailClient)
        {
            Console.WriteLine($"Sending email to retail client {retailClient.GetEmail()}");
        }
    }
}