namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.State.GoodSolution
{
    public class ModerationState : State
    {
        private Document document;

        public ModerationState(Document document)
        {
            this.document = document;
        }

        public void Publish()
        {
            if (this.document.CurrentUserRole == UserRole.Admin)
            {
                this.document.State = new PublishedState(this.document);
            }
            else
            {
                throw new Exception("You do not have permission to publish this document");
            }
            
        }
    }
}