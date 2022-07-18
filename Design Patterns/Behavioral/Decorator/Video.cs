namespace Design_Patterns.Behavioral.Decorator
{
    public class Video : LibraryItem
    {
        public string? PlayTime { get; set; }
        public Video(string name, int numOfCopies,string playTime):base(name,numOfCopies)
        {
            PlayTime = playTime;
        }
        public override void Display()
        {
            Console.WriteLine($"VIDEO: Name: {Name}, Playtime: {PlayTime}, Number of available copies: {NumOfCopies}");
        }
    }
}
