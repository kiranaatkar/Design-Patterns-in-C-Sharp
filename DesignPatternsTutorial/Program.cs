// using DesignPatternsTutorial.src.OopPrinciples.Encapsulation;
// using DesignPatternsTutorial.src.OopPrinciples.Abstraction;
//using DesignPatternsTutorial.src.OopPrinciples.Inheritance;
//using DesignPatternsTutorial.src.OopPrinciples.Polymorphism;
//using DesignPatternsTutorial.src.OopPrinciples.Coupling;

// Encapsulation

// BAD
// BadBankAccount badAccount = new BadBankAccount();
// badAccount.balance = 100;
// Console.WriteLine(badAccount.balance);
// badAccount.balance = -100;
// Console.WriteLine(badAccount.balance);
// GOOD
// BankAccount bankAccount = new BankAccount(100);
// Console.WriteLine(bankAccount.GetBalance());
// bankAccount.Deposit(50);
// Console.WriteLine(bankAccount.GetBalance());
// bankAccount.Withdraw(1000);
// Console.WriteLine(bankAccount.GetBalance());



// Abstraction
// //BAD
// EmailServiceBad emailServiceBad = new EmailServiceBad();
// emailServiceBad.Connect();
// emailServiceBad.Authenticate();
// emailServiceBad.SendEmail();
// emailServiceBad.Disconnect();
// // GOOD 
// EmailService emailService = new EmailService();
// emailService.SendEmail();



// Inheritance
// var car = new Car();
// var bike = new Bike();
// // shared properties
// car.Start();
// car.Stop();
// bike.Start();
// bike.Stop();
// // Unique properties
// car.NumberOfDoors = 4;
// Console.WriteLine(car.NumberOfDoors);
// //bike.NumberOfDoors = 2; // wont work



// // Polymorphism
// List<Vehicle> vehicles = new List<Vehicle>();
// vehicles.Add(new Car { Brand = "Toyota", Model = "Camry", Year = 2020, NumberOfDoors = 4});
// vehicles.Add(new Motorcycle { Brand = "Harley Davidson", Model = "Sportster", Year = 2020});

// // without polymorphism, would have to initiate List<object> then check type each time to see if Start method exists.
// foreach(var vehicle in vehicles) 
// {
//     vehicle.Start();
// }




// // Coupling
// var order1 = new Order(new EmailSender());
// var order2 = new Order(new SmsSender());
// order1.Placeorder();
// order2.Placeorder();




// Composition
// using DesignPatternsTutorial.src.OopPrinciples.Composition;

// var car = new Car();
// car.StartCar();

















// ___________________________ SOLID PRINCIPLES _____________________________

