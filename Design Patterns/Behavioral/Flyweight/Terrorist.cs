namespace Design_Patterns.Behavioral.Flyweight
{
    public class Terrorist : Player
    {
        public string? Weapon { get; set; }
        public string? Task { get; set; }
        public Terrorist()
        {
            Task=typeof(Terrorist).Name;
        }

        public void AssignWeapon(string weapon)
        {
            Weapon = weapon;
        }

        public void Display()
        {
            Console.WriteLine($"Plant bomb. Current weapon: {Weapon}");
        }
    }
}
