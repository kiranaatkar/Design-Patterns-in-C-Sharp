namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.State.GoodSolution
{
    public class PublishedState : State
    {
        private Document document;
        public PublishedState(Document document)
        {
            this.document = document;
        }
        public void Publish()
        {
            throw new Exception("Document is already published");
        }
    }
}