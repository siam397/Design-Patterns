namespace Design_Patterns.Behavioral.Decorator
{
    public class Book : LibraryItem
    {
        public string? Author { get; set; }
        public Book(string name, string author,int numOfCopies):base(name,numOfCopies)
        { 
            Author = author;
        }
        public override void Display()
        {
            Console.WriteLine($"BOOK: Name: {Name}, Author: {Author}, Number of available copies: {NumOfCopies}");
        }
    }
}
