namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.State.GoodSolution
{
    public class DraftState : State
    {
        private Document document;

        public DraftState(Document document)
        {
            this.document = document;
        }

        public void Publish()
        {
            this.document.State = new ModerationState(this.document);
        }
    }
}