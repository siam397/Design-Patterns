// See https://aka.ms/new-console-template for more information
using Design_Patterns.Creational.Builder;
using Design_Patterns.Creational.Factory_Method;
using Design_Patterns.Structural.Observer;
using Design_Patterns.Structural.Strategy;

//Console.WriteLine("hello, world!");


//factory method
WeaponInventory weaponInventory = new WeaponInventory();
weaponInventory.setWeapons();
weaponInventory.getWeapons();

//observer pattern
//Game game = new Game();
//game.gameRunning();

//builder pattern
//CharacterCustomization characterCustomization = new CharacterCustomization();
//ICharacterBuilder samurai = new SamuraiBuilder();
//characterCustomization.construct(samurai, "ronin");
//samurai.showInformation();
