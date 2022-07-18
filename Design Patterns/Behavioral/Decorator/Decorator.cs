namespace Design_Patterns.Behavioral.Decorator
{
    public abstract class Decorator
    {
        public LibraryItem libraryItem;
        
        public Decorator(LibraryItem libraryItem)
        {
            this.libraryItem = libraryItem;
        }

        public abstract void ExtendedFeatures();
    }
}
