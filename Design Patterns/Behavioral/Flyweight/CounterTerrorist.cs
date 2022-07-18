namespace Design_Patterns.Behavioral.Flyweight
{
    public class CounterTerrorist : Player
    {
        public string? Weapon { get; set; }
        public string? Task { get; set; }

        public CounterTerrorist()
        {
            Task = typeof(CounterTerrorist).Name;
        }

        public void AssignWeapon(string weapon)
        {
            Weapon = weapon;
        }

        public void Display()
        {
            Console.WriteLine($"Defuse bomb or prevent terrorists from planting a bomb. Current weapon: {Weapon}");
        }
    }
}
