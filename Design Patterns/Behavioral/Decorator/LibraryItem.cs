namespace Design_Patterns.Behavioral.Decorator
{
    public abstract class LibraryItem
    {
        public string? Name { get; set; }
        public int NumOfCopies { get; set; }
        public LibraryItem(string name,int numOfCopies)
        {
            Name = name;
            NumOfCopies = numOfCopies;
        }
        public abstract void Display();

        public void reduceNumofCopy()
        {
            NumOfCopies--;
        }

        public void AddaCopy()
        {
            NumOfCopies++; 
        }
    }
}
