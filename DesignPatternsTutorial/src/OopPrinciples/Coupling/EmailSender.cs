namespace DesignPatternsTutorial.src.OopPrinciples.Coupling
{
  public class EmailSender : INotificationService
  {
        public void SendNotification(string message)
        {
            Console.WriteLine("Sending email: " + message);
        }
    }
}