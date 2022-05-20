namespace Design_Patterns.Creational.Prototype
{
    public interface ICloneBoss
    {
        void Attack();
        ICloneBoss? Clone();
    }
}
