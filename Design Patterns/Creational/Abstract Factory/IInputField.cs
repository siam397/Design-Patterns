namespace Design_Patterns.Creational.Abstract_Factory
{
    public interface IInputField
    {
        void ListenToChange();
        void SetDefaultValue(string defaultValue);
        void AddValidation(string validation);
    }
}
