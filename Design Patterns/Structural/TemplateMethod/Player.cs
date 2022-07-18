namespace Design_Patterns.Structural.TemplateMethod
{
    public class Player : Character
    {
        public override void Slash()
        {
            Console.WriteLine("Player used slash");
        }

        public override void UpdateHealthBar()
        {
            Console.WriteLine("Enemy health reduced by 10");
        }
    }
}
