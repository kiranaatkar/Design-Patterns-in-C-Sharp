namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.State
{
    public class Document
    {
        public DocumentState State { get; set; }
        public UserRole CurrentUserRole { get; set; }

        public void Publish()
        {
            if (State == DocumentState.Draft)
            {
                State = DocumentState.Moderation;
            }
            else if (State == DocumentState.Moderation && CurrentUserRole == UserRole.Admin)
            {
                State = DocumentState.Published;
            }
            else if (State == DocumentState.Published)
            {
                Console.WriteLine("Document is already published");
            }
            else
            {
                Console.WriteLine("You don't have permission to publish this document");
            }
        }
    }
}