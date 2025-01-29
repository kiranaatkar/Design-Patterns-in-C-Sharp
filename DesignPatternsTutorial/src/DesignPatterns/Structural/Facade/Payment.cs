namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Facade
{
    public class Payment
    {
        private readonly string _name;
        private readonly string _cardNumber;
        private readonly float _amount;

        public Payment(string name, string cardNumber, float amount)
        {
            _name = name;
            _cardNumber = cardNumber;
            _amount = amount;
        }

        public void Pay()
        {
            Console.WriteLine($"Paying {_amount} with card number {_cardNumber} for {_name}");
        }
    }
}