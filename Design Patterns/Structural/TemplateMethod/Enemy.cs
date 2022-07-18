namespace Design_Patterns.Structural.TemplateMethod
{
    public class Enemy : Character
    {
        public override void Slash()
        {
            Console.WriteLine("Enemey used slash");
        }

        public override void UpdateHealthBar()
        {
            Console.WriteLine("Player health reduced by 10");
        }
    }
}
