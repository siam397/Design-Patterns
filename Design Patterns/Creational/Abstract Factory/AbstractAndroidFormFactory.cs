namespace Design_Patterns.Creational.Abstract_Factory
{
    public class AbstractAndroidFormFactory : AbstractFormFactory
    {
        public IButton GetButton()
        {
            return new AndroidButton();
        }

        public IInputField GetInputField()
        {
            return new AndroidInputField();
        }
    }
}
