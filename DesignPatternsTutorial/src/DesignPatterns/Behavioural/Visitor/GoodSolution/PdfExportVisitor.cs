namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Visitor.GoodSolution
{
    public class PdfExportVisitor : Visitor
    {
        public void VisitLaw(LawClient lawClient)
        {
            Console.WriteLine($"Exporting law client {lawClient.GetEmail()} to PDF");
        }

        public void VisitRestaurant(RestaurantClient financeClient)
        {
            Console.WriteLine($"Exporting restaurant client {financeClient.GetEmail()} to PDF");
        }

        public void VisitRetail(RetailClient retailClient)
        {
            Console.WriteLine($"Exporting retail client {retailClient.GetEmail()} to PDF");
        }
        
    }
}