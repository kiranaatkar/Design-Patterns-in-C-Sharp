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

// using DesignPatternsTutorial.src.DesignPatterns.Behavioural.MediatorWithObserver;
// var dialogBox = new PostsDialogBox();
// dialogBox.SimulateUserInteraction();





// CHAIN OF RESPONSIBILITY PATTERN
// BAD
// using DesignPatternsTutorial.src.DesignPatterns.Behavioural.ChainOfResponsibility;
// var webServer = new WebServer();
// webServer.Handle(new HttpRequest("admin", "1234"));

// GOOD
// using DesignPatternsTutorial.src.DesignPatterns.Behavioural.ChainOfResponsibility.GoodSolution;
// var validator = new Validator();
// var authenticator = new Authenticator();
// var logger = new Logger();

// validator.SetNext(authenticator).SetNext(logger);

// var webServer = new WebServer(validator);
// webServer.Handle(new HttpRequest("kit", "123"));









// VISITOR PATTERN
// BAD
// This violates the SRP as clients are responsible for sending emails and storing information 
// using DesignPatternsTutorial.src.DesignPatterns.Behavioural.Visitor;
// var clients = new List<Client>
// {
//     new LawClient("Law Client", "email.co.uk"),
//     new RetailClient("Retail Client", "email.co.uk"),
//     new RestaurantClient("Restaurant Client", "email.co.uk")
// };
// foreach(var client in clients)
// {
//     client.SendEmail();
// } 
// GOOD
// Now, if we want new features for each client we just need a new visitor, instead of having to 
// modify the client classes.
// using DesignPatternsTutorial.src.DesignPatterns.Behavioural.Visitor.GoodSolution;
// var clients = new List<Client>
// {
//     new LawClient("Law Client", "email.co.uk"),
//     new RetailClient("Retail Client", "email.co.uk"),
//     new RestaurantClient("Restaurant Client", "email.co.uk")
// };

// foreach(var client in clients)
// {
//     client.Accept(new EmailVisitor());
//     client.Accept(new PdfExportVisitor());
// }









// Interpreter pattern
// using DesignPatternsTutorial.src.DesignPatterns.Behavioural.Interpreter;
// var context = new Context();
// var interpreter = new Interpreter(context);
// Console.WriteLine(interpreter.Interpret("1+2*3"));





// STRUCTURAL PATTERNS

// COMPOSITE PATTERN
// using DesignPatternsTutorial.src.DesignPatterns.Structural.Composite;
// var box = new Box();
// box.Add(new Microphone());
// box.Add(new Mouse());
// Console.WriteLine(box.GetPrice());

// var box2 = new Box();
// box2.Add(new Microphone());
// box2.Add(new Mouse());
// box2.Add(box);
// Console.WriteLine(box2.GetPrice());





// ADAPTER PATTERN
// using DesignPatternsTutorial.src.DesignPatterns.Structural.Adapter;
// using DesignPatternsTutorial.src.DesignPatterns.Structural.Adapter.Package;
// var video = new Video();
// var rainbow = new Rainbow();
// var rainbowColor = new RainbowColor(rainbow);
// var videoEditor = new VideoEditor(video);
// videoEditor.ApplyColor(rainbowColor);



// BRIDGE PATTERN
// BAD
// eery time we add a new brand, we need to create 3 new classes, every time we need a new remote type
// we need to implement it for each brand, so it grows in two dimensions, to simplify, use the bridge pattern
// to split it into brand and type hierarchys
// using DesignPatternsTutorial.src.DesignPatterns.Structural.Bridge;
// var lgRemote = new AdvancedLGRemote();
// lgRemote.SetChannel(5);
// lgRemote.TurnOn();
// lgRemote.VolumeUp();
// lgRemote.VolumeDown();
// lgRemote.TurnOff();

// GOOD
// using DesignPatternsTutorial.src.DesignPatterns.Structural.Bridge.Good;
// var lgRemote = new RemoteControl(new LgRadio());
// lgRemote.TurnOn();
// lgRemote.TurnOff();

// var sonyRemote = new AdvancedRemote(new SonyRadio());
// sonyRemote.TurnOn();
// sonyRemote.TurnOff();
// sonyRemote.SetChannel(5);








// PROXY PATTERN
// BAD
// has to download everything even thoughwe only want to watch '1'
// using DesignPatternsTutorial.src.DesignPatterns.Structural.Proxy.Bad.Package;
// using DesignPatternsTutorial.src.DesignPatterns.Structural.Proxy.Bad;
// var videoList = new VideoList();
// string[] videoIds = new string[] {"1", "2"};

// foreach(var videoId in videoIds)
// {
//     videoList.AddVideo(new YoutubeVideo(videoId));
// }

// videoList.Watch("1");

// GOOD
// now, only the video we want to watch is downloaded
// using DesignPatternsTutorial.src.DesignPatterns.Structural.Proxy.Good;
// var videoList = new VideoList();
// string[] videoIds = new string[] {"1", "2"};
// foreach(var videoId in videoIds)
// {
//     videoList.AddVideo(new YoutubeVideoProxy(videoId));
// }
// videoList.Watch("1");






// FLYWEIGHT PATTERN
// using DesignPatternsTutorial.src.DesignPatterns.Structural.Flyweight;
// var cropService = new CropService(new CropIconFactory());
// var crops = cropService.GetCrops();
// foreach(var crop in crops)
// {
//     crop.Render();
// }





//Facade PATTERN
// using DesignPatternsTutorial.src.DesignPatterns.Structural.Facade;
// var orderReq = new OrderRequest();
// var orderService = new OrderService();
// orderService.Order(orderReq);







// DECORATOR PATTERN
// BAD
// using DesignPatternsTutorial.src.DesignPatterns.Structural.Decorator;
// var url = "http://cloud.com/data";
// var data = "Hello World";
// var compress = true;
// var encrypt = true;

// var cloudData = new CloudData(url);

// if(compress && encrypt)
// {
//     cloudData = new CompressedAndEncryptedData(url);
// }
// else if(compress)
// {
//     cloudData = new CompressedData(url);
// }
// else if(encrypt)
// {
//     cloudData = new EncryptedData(url);
// }

// cloudData.Save(data);
// GOOD
// using DesignPatternsTutorial.src.DesignPatterns.Structural.Decorator.Good;
// var url = "http://cloud.com/data";
// var data = "Hello World";
// var compress = true;
// var encrypt = true;
// Data cloudData = new CloudData(url);
// if (encrypt)
// {
//     cloudData = new EncryptionDecorator(cloudData);
// }
// if (compress)
// {
//     cloudData = new CompressionDecorator(cloudData);
// }
// cloudData.Save(data);








// CREATIONAL DESIGN PATTERNS

// PROTOTYPE
// using DesignPatternsTutorial.src.DesignPatterns.Creational.Prototype;
// var circle = new Circle();
// circle.Draw();
// // user resizes
// circle.Radius = 10;
// // user duplicates
// var shapeActions = new ShapeActions();
// Shape newCircle = shapeActions.Duplicate(circle);
// newCircle.Draw();
// var rectangle = new Rectangle();
// rectangle.Draw();
// // user resizes
// rectangle.width = 20;
// rectangle.height = 10;
// // user duplicates
// Shape newRectangle = shapeActions.Duplicate(rectangle);
// newRectangle.Draw();





// SINGLETON
// BAD - creates a new instance each time, so each client which uses it wont have the new settings
// using DesignPatternsTutorial.src.DesignPatterns.Creational.Singleton;
// var appSettings = new AppSettings();
// appSettings.Set("theme", "dark");
// appSettings.Set("font", "arial");
// Console.WriteLine(appSettings.Get("theme"));
// Test.Run();
// GOOD
// using DesignPatternsTutorial.src.DesignPatterns.Creational.Singleton.Good;
// var appSettings = AppSettings.GetInstance();
// appSettings.Set("theme", "dark");
// appSettings.Set("font", "arial");
// Console.WriteLine(appSettings.Get("theme"));
// Test.Run();







// ABSTRACT AbstractFactory
using DesignPatternsTutorial.src.DesignPatterns.Creational.AbstractFactory;
// var os = OperatingSystemType.Windows;
// var userSettingsForm = new UserSettingsForm();
// userSettingsForm.Render(os);

var os = OperatingSystemType.Mac;
IUIComponentFactory uiComponentFactory;

if (os == OperatingSystemType.Windows)
{
    uiComponentFactory = new WindowsComponentFactory();
}
else if (os == OperatingSystemType.Mac)
{
    uiComponentFactory = new MacComponentFactory();
}
else 
{
    throw new Exception("Unknown operating system");
}

new UserSettingsForm().Render(uiComponentFactory);