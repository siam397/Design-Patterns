namespace Design_Patterns.Structural.TemplateMethod
{
    public abstract class Character
    {
        public abstract void Slash();
        public abstract void UpdateHealthBar();

        //Template Method
        public void OnHit()
        {
            Slash();
            UpdateHealthBar();
        }
    }
}
