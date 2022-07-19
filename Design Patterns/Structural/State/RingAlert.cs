namespace Design_Patterns.Structural.State
{
    public class RingAlert : IMobileAlertState
    {
        public void Alert()
        {
            Console.WriteLine("Ringing...");
        }
    }
}
