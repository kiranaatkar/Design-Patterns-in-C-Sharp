namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Visitor.GoodSolution
{
    public interface Visitor
    {
        public void VisitRetail(RetailClient retailClient);
        public void VisitLaw(LawClient lawClient);
        public void VisitRestaurant(RestaurantClient financeClient);
    }
}