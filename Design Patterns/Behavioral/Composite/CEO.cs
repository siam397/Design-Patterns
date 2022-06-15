namespace Design_Patterns.Behavioral.Composite
{
    public class CEO : Employee
    {
        private IList<Employee> _employees;
        public CEO(string name,int salary):base(name,salary){
            Name = name;
            Salary = salary;
            _employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            _employees.Remove(employee);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-',depth) + " " + "Name: " + this.Name + " , Salary: " + this.Salary);
            foreach (var employee in _employees)
            {
                employee.Display(depth+2);
            }
        }
    }
}
