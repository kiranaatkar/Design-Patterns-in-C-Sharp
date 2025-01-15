namespace DesignPatternsTutorial.src.OopPrinciples.Encapsulation 
{
    public class BankAccount
    {
        public BankAccount(decimal balance) 
        {
            Deposit(balance);
        }
        private decimal balance = 0;

        public decimal GetBalance()
        {
            return this.balance;
        }

        public void Deposit(decimal amount) 
        {
            if (amount <= 0) 
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            this.balance += amount;
        }

        public void Withdraw (decimal amount)
        {
            if (amount <= 0) 
            {
                throw new ArgumentException("Withdrawal amount must be positive");
            }
            if (amount > this.balance) 
            {
                throw new ArgumentException("Withdraw request exceeds account balance.");
            }
            this.balance -= amount;
        }
    }
}