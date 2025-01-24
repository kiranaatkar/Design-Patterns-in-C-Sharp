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

// LSP 
// using DesignPatternsTutorial.src.SOLID.L;

// // if you replace superclass (Rectangle) with subclass (Square) and re run the program
// // the calculated area will be different. This violates the Liskov Substitution Principle.
// // Instead, the Square class should inherit from a Shape class and implement the Area property.
// var rect = new Rectangle();
// rect.Width = 10;
// rect.Height = 5;
// Console.WriteLine(rect.Area);




// ___________________________ DESIGN PATTERNS _____________________________

// MOMENTO
// using DesignPatternsTutorial.src.DesignPatterns.Behavioural.Momento;
// var editor = new Editor();
// var history = new History(editor);
// history.BackUp();
// editor.Title = "Title 1";
// history.BackUp();
// editor.Content = "Content 1";
// history.BackUp();
// editor.Title = "Title 2";
// history.ShowHistory();
// Console.WriteLine("Current state: " + editor.Title + " " + editor.Content);
// history.Undo();
// Console.WriteLine("After 1 undo: " + editor.Title + " " + editor.Content);
// history.ShowHistory();


// STRATEGY
// using DesignPatternsTutorial.src.DesignPatterns.Behavioural.Strategy.GoodSolution;
// var videoEditor = new VideoStorage(new CompressorMp4(), new OverlayNone());
// videoEditor.Store("video1");

// videoEditor.SetCompressor(new CompressorMOV());
// videoEditor.SetOverlay(new OverlayBlur());
// videoEditor.Store("video2");

// ITERATOR
// BAD solution - If list changes from List<string> to string[50] then this breaks
// as .Count is not available on string[50]
// using DesignPatternsTutorial.src.DesignPatterns.Behavioural.Iterator;
// ShoppingList shoppingList = new ShoppingList();
// shoppingList.Push("Apple");
// shoppingList.Push("Banana");
// shoppingList.Push("Orange");

// for (int i = 0; i < shoppingList.GetList().Count; i++)
// {
//     Console.WriteLine(shoppingList.GetList()[i]);
// }

// GOOD solution - If list changes from List<string> to string[50] then this still works
// using DesignPatternsTutorial.src.DesignPatterns.Behavioural.Iterator.GoodSolution;
// ShoppingList shoppingList = new ShoppingList();
// shoppingList.Push("Apple");
// shoppingList.Push("Banana");
// shoppingList.Push("Orange");

// var iterator = shoppingList.CreateIterator();
// while (iterator.HasNext())
// {
//     Console.WriteLine(iterator.Current());
//     iterator.Next();
// } 


// COMMAND PATTERN
// BAD SOLUTION - directly calling methods on light class from remote class - tightly coupled, 
//  violating the open/closed principle.
// using DesignPatternsTutorial.src.DesignPatterns.Behavioural.Command;
// var light = new Light();
// var remote = new RemoteControl(light);

// remote.PressButton(true);
// remote.PressButton(false);

// GOOD SOLUTION - using command pattern
// using DesignPatternsTutorial.src.DesignPatterns.Behavioural.Command.GoodSolution;
// var light = new Light();
// var remote = new RemoteControl(new TurnOnCommand(light));
// remote.PressButton();
// remote.SetCommand(new DimCommand(light));
// remote.PressButton();

// UNDO for COmmand pattern
// using DesignPatternsTutorial.src.DesignPatterns.Behavioural.Command.Undoable;
// var htmlDoc = new HtmlDocument();
// var history = new CommandHistory();
// htmlDoc.Content = "Hello World";
// Console.WriteLine(htmlDoc.Content);

// var italicCommand = new ItalicCommand(htmlDoc, history);
// italicCommand.Execute();
// Console.WriteLine(htmlDoc.Content);

// var undoCommand = new UndoCommand(history);
// undoCommand.Execute();
// Console.WriteLine(htmlDoc.Content);




// TEMPLATE PATTERN
// BAD EXAMPLE
// using DesignPatternsTutorial.src.DesignPatterns.Behavioural.Template.BadExample;
// var coffee = new Tea();
// coffee.MakeBeverage();
// Using strategy pattern
// using DesignPatternsTutorial.src.DesignPatterns.Behavioural.Template.StrategyPattern;
// var coffee = new BeverageMaker(new Coffee());
// coffee.MakeBeverage();
// using temoplate method
// using DesignPatternsTutorial.src.DesignPatterns.Behavioural.Template.TemplateMethod;
// var tea = new Tea();
// tea.Prepare();
// var chamomile = new Chamomile();
// chamomile.Prepare();






// Observer Pattern
// BAD
// using DesignPatternsTutorial.src.DesignPatterns.Behavioural.Observer;
// var dataSource  = new DataSource();
// var spreadsheet = new Spreadsheet2();
// var barChart = new BarChart();
// dataSource.AddDependant(spreadsheet);
// dataSource.AddDependant(barChart);
// dataSource.SetValues(new List<int> {1, 2, 3});
// dataSource.RemoveDependant(spreadsheet);
// dataSource.SetValues(new List<int> {4, 5, 6});
// GOOD
// using DesignPatternsTutorial.src.DesignPatterns.Behavioural.Observer.GoodSolution;
// var dataSource  = new DataSource();
// var spreadsheet = new Spreadsheet2(dataSource);
// var barChart = new BarChart(dataSource);
// dataSource.AddObserver(spreadsheet);
// dataSource.AddObserver(barChart);
// dataSource.SetValues(new List<int> {1, 2, 3});
// dataSource.RemoveObserver(barChart);
// dataSource.SetValues(new List<int> {4, 5, 6});




// MEDIATOR PATTERN 
// using DesignPatternsTutorial.src.DesignPatterns.Behavioural.Mediator;
// var dialogBox = new PostsDialogBox();
// dialogBox.SimulateUserInteraction();

using DesignPatternsTutorial.src.DesignPatterns.Behavioural.MediatorWithObserver;
var dialogBox = new PostsDialogBox();
dialogBox.SimulateUserInteraction();
