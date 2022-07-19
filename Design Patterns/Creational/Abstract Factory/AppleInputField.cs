namespace Design_Patterns.Creational.Abstract_Factory
{
    public class AppleInputField : IInputField
    {
        public void AddValidation(string validation)
        {
            Console.WriteLine($"{validation} Added inside the input field on an apple device.");
        }

        public void ListenToChange()
        {
            Console.WriteLine("Values changed inside an apple device.");
        }

        public void SetDefaultValue(string defaultValue)
        {
            Console.WriteLine($"Default value set as {defaultValue} for the input field on an apple device.");
        }
    }
}
