namespace Design_Patterns.Creational.Abstract_Factory
{
    public class AppleButton : IButton
    {
        public void AddButtonClickListener()
        {
            Console.WriteLine("Button clicked on an apple device");
        }
    }
}
