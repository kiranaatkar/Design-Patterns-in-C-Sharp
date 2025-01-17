namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.State.GoodSolution
{
    public class Document
    {
        public State State { get; set; }
        public UserRole CurrentUserRole { get; set; }

        public Document(UserRole currentUserRole)
        {
            State = new DraftState(this);
            CurrentUserRole = currentUserRole;
        }
        public void Publish()
        {
            State.Publish();
        }
    }
}