// Encapsulation

using DesignPatternsTutorial.src.OopPrinciples.Encapsulation;

// BadBankAccount badAccount = new BadBankAccount();
// badAccount.balance = 100;
// Console.WriteLine(badAccount.balance);
// badAccount.balance = -100;
// Console.WriteLine(badAccount.balance);

BankAccount bankAccount = new BankAccount(100);
Console.WriteLine(bankAccount.GetBalance());

bankAccount.Deposit(50);
Console.WriteLine(bankAccount.GetBalance());

bankAccount.Withdraw(1000);
Console.WriteLine(bankAccount.GetBalance());