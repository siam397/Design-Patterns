namespace Design_Patterns.Creational.Abstract_Factory
{
    public class AbstractAppleFormFactory : AbstractFormFactory
    {
        public IButton GetButton()
        {
            return new AppleButton();
        }

        public IInputField GetInputField()
        {
            return new AppleInputField();
        }
    }
}
