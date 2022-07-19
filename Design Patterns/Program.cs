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






//Chain of Responsibility pattern with logger//
//using Design_Patterns.Behavioral.ChainofResponsibility.Logger
//Logger logger = Logger.GetLoggerConfiguration();
//logger.logMessage(Logger.ERROR, "Error in server");
//logger.logMessage(Logger.WARNING, "Should use using keyword");
//logger.logMessage(Logger.INFO, "logger function works");




//Chain of Responsibility pattern with auth//
//using Design_Patterns.Behavioral.ChainofResponsibility.Authentication;

//AuthHandler authHandler= AuthHandler.GetAuthConfig();
//authHandler.Handle("Himel Kabir", "FAHIMMIA");








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





//Decorator Pattern//

//using Design_Patterns.Behavioral.Decorator;

//Book book = new Book("Worley", "Inside ASP.NET", 10);
//book.Display();
//Video video = new Video("Jaws", 23, "1:30:23");
//video.Display();
//Console.WriteLine("\nAfter Himel Mia and Fahim Kabir borrows the book");
//Borrowable borrowvideo = new Borrowable(video);
//borrowvideo.LendACopy("Fahim Kabir");
//borrowvideo.LendACopy("Himel Mia");
//borrowvideo.ExtendedFeatures();
//video.Display();
//borrowvideo.ReceiveACopy("Himel Mia");
//Console.WriteLine("After himel mia gives back the book\n");
//borrowvideo.ExtendedFeatures();
//video.Display();
//Console.ReadKey();













//Flyweight Pattern//

//using Design_Patterns.Behavioral.Flyweight;

//string[] weapons = new string[] { "AK47", "M4A4", "SCAR20", "DEAGLE", "AWP" };

//for (int i = 0; i < 5; i++)
//{
//    Player player = PlayerFactory.GetPlayer("Terrorist");
//    AssignRandomWeaponForPlayer(player);
//    player.Display();
//    Console.WriteLine("\n");
//}

//for (int i = 0; i < 5; i++)
//{
//    Player player = PlayerFactory.GetPlayer("CounterTerrorist");
//    AssignRandomWeaponForPlayer(player);
//    player.Display();
//    Console.WriteLine("\n");
//}


//void AssignRandomWeaponForPlayer(Player player)
//{
//    Random r = new Random();
//    int rInt = r.Next(0, 5);
//    player.AssignWeapon(weapons[rInt]);
//}







//Abstract Factory Pattern//

//using Design_Patterns.Creational.Abstract_Factory;

//AbstractFormFactory androidForm= new AbstractAndroidFormFactory();
//IButton androidButton = androidForm.GetButton();
//IInputField androidInput = androidForm.GetInputField();
//androidInput.SetDefaultValue("ANDROID");
//androidInput.AddValidation("MIN VALUE 6");
//androidInput.ListenToChange();
//androidButton.AddButtonClickListener();

//AbstractFormFactory appleForm = new AbstractAppleFormFactory();
//IButton appleButton = appleForm.GetButton();
//IInputField appleInput = appleForm.GetInputField();
//appleInput.SetDefaultValue("APPLE");
//appleInput.AddValidation("MIN VALUE 8");
//appleInput.ListenToChange();
//appleButton.AddButtonClickListener();














//State Pattern//

//using Design_Patterns.Structural.State;

//MobileAlertContext alertContext = new MobileAlertContext(new RingAlert());
//alertContext.HandleOperation();

//alertContext.SetState(new VibrationAlert());
//alertContext.HandleOperation();

//alertContext.SetState(new SilentAlert());
//alertContext.HandleOperation();









