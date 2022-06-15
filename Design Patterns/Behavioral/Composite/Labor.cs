namespace Design_Patterns.Behavioral.Composite
{
    public class Labor : Employee
    {
        public Labor(string name,int salary) : base(name, salary)
        {
            Name = name;
            Salary = salary;
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + " "+"Name: "+this.Name+" Salary: "+Salary);
        }
    }
}
