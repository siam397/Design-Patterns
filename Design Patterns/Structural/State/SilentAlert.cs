namespace Design_Patterns.Structural.State
{
    public class SilentAlert : IMobileAlertState
    {
        public void Alert()
        {
            Console.WriteLine("Silent...");
        }
    }
}
