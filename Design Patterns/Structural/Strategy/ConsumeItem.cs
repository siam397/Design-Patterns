
namespace Design_Patterns.Structural.Strategy
{
    public class ConsumeItem
    {

        public void consume(IConsumable consumable)
        {
            consumable.consume();
        }
    }
}
