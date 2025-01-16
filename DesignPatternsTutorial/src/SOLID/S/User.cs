namespace DesignPatternsTutorial.src.SOLID.S
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }

        // Used to contain Register method but that would give this more than one responsibility
        // this is now used for just storing user data, the service is used for handling user functions.
    }
}

