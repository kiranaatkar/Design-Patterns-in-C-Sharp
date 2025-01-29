namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Facade
{
    public class OrderRequest
    {
        public string Name { get; } = "John Doe";
        public string Address { get; } = "1234 Elm Street";
        public string CardNumber { get; } = "1234 5678 9012 3456";
        public float Amount { get; } = 100.00f;
        public string[] ItemIds { get; } = new string[] { "1", "2", "3" };
    }
}