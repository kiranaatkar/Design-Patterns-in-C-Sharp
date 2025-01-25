namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Visitor.GoodSolution
{
    public class LawClient : Client
    {
        public LawClient(string name, string email) : base(name, email)
        {
        }

        public override void Accept(Visitor visitor)
        {
            visitor.VisitLaw(this);
        }
    }
}