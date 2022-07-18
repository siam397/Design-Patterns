//factory method//

//using Design_Patterns.Creational.Factory_Method;
//WeaponInventory weaponInventory = new WeaponInventory();
//weaponInventory.setWeapons();
//weaponInventory.getWeapons();





//observer pattern//
//using Design_Patterns.Structural.Observer;
//Game game = new Game();
//game.gameRunning();




//builder pattern//
//using Design_Patterns.Creational.Builder;
//CharacterCustomization characterCustomization = new CharacterCustomization();
//ICharacterBuilder samurai = new SamuraiBuilder();
//characterCustomization.construct(samurai, "ronin");
//samurai.showInformation();




//prototype pattern//
//using Design_Patterns.Creational.Prototype;
//BossMimicTear mimicTear=new BossMimicTear();
//BossMimicTear? mimicTearClone=mimicTear.Clone() as BossMimicTear;
//Console.WriteLine("mimic tear attack");
//mimicTear.Attack();
//BossCloneMaster cloneMaster=new BossCloneMaster();
//BossCloneMaster? cloneMasterClone=cloneMaster.Clone() as BossCloneMaster;
//Console.WriteLine("clone master attack");
//cloneMasterClone.Attack();






//Chain of Responsibility pattern//
//using Design_Patterns.Behavioral.ChainofResponsibility;
//Logger logger= Logger.GetLoggerConfiguration();
//logger.logMessage(Logger.ERROR, "Error in server");
//logger.logMessage(Logger.WARNING, "Should use using keyword");
//logger.logMessage(Logger.INFO, "logger function works");








//Composite Pattern//
//using Design_Patterns.Behavioral.Composite;
//CEO ceo = new CEO("Hemale",2);
//Manager bappy = new("Bappy", 4);
//Manager anindo = new("Anindo", 4);
//Labor fahim = new Labor("Fahim mia", 5);
//Labor kongmin = new("Kongming", 7);

//ceo.AddEmployee(bappy);
//ceo.AddEmployee(anindo);
//anindo.AddEmployee(fahim);
//bappy.AddEmployee(kongmin);
//ceo.Display(0);









//Facade Pattern//
//using Design_Patterns.Behavioral.Facade;
//Body body = new();
//body.EatFood("burger");






//Template Mehod//

//using Design_Patterns.Structural.TemplateMethod;

//Character Player = new Player();
//Character Enemy = new Enemy();
//Player.OnHit();
//Enemy.OnHit();





//Decorator Pattern

using Design_Patterns.Behavioral.Decorator;

Book book = new Book("Worley", "Inside ASP.NET", 10);
book.Display();
Video video = new Video("Jaws", 23, "1:30:23");
video.Display();
Console.WriteLine("\nAfter Himel Mia and Fahim Kabir borrows the book");
Borrowable borrowvideo = new Borrowable(video);
borrowvideo.LendACopy("Fahim Kabir");
borrowvideo.LendACopy("Himel Mia");
borrowvideo.ExtendedFeatures();
video.Display();
borrowvideo.ReceiveACopy("Himel Mia");
Console.WriteLine("After himel mia gives back the book\n");
borrowvideo.ExtendedFeatures();
video.Display();
Console.ReadKey();