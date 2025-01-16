namespace DesignPatternsTutorial.src.SOLID.S
{
    public class EmailSender
    {
        public void SendEmail(string email, string message)
        {
            Console.WriteLine($"Sending to {email}: {message}");
        }
    }
}