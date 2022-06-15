﻿namespace Design_Patterns.Behavioral.Composite
{
    public abstract class Employee
    {
        public string? Name { get; set; }
        public int? Salary { get; set; }

        public Employee(string name,int salary)
        {
            Name = name;
            Salary = salary;
        }
        public abstract void Display(int depth);
    }
}
