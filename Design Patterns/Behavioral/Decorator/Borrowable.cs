namespace Design_Patterns.Behavioral.Decorator
{
    public class Borrowable : Decorator
    {
        public IList<string?> _borrowers = new List<string?>();
        public Borrowable(LibraryItem libraryItem) : base(libraryItem)
        {
            
        }

        public void LendACopy(string name)
        {
            if (this.libraryItem.NumOfCopies != 0)
            {
                this._borrowers.Add(name);
                this.libraryItem.reduceNumofCopy();
                return;
            }
            Console.WriteLine("No more copies available");
        }

        public void ReceiveACopy(string name)
        {
            if (_borrowers.Contains(name))
            {
                _borrowers.Remove(name);
            }
            this.libraryItem.AddaCopy();
        }

        public override void ExtendedFeatures()
        {
            foreach (var borrower in _borrowers)
            {
                Console.WriteLine($"Name of borrower: {borrower}\n");
            }
        }
    }
}
