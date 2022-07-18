namespace Design_Patterns.Behavioral.Facade
{
    public class Body
    {
        Hand hand = new();
        Legs legs=new();
        Mouth mouth=new();

        public void EatFood(string food)
        {
            legs.Walk("to "+food);
            hand.Grab(food);
            mouth.Consume(food);
        }

    }
}
