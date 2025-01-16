namespace DesignPatternsTutorial.src.SOLID.S
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }

        public void Register() 
        {
            // Register user logic

            // send email
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail(Email, "Welcome to our platform");
            
        }
    }
}

