namespace Design_Patterns.Creational.Abstract_Factory
{
    public class AndroidInputField : IInputField
    {
        public void AddValidation(string validation)
        {
            Console.WriteLine($"{validation} Added inside the input field on an android device.");
        }

        public void ListenToChange()
        {
            Console.WriteLine("Values changed inside an android device.");
        }

        public void SetDefaultValue(string defaultValue)
        {
            Console.WriteLine($"Default value set as {defaultValue} for the input field on an android device.");
        }
    }
}
