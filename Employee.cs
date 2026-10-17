using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    public abstract class Employee
    {
        private int _Salary { get; set; }
        public int Salary
        {
            get { return _Salary; }
            protected set { _Salary = value; }
        }
        public string Name { get; set; }
        public int Id { get; set; }

        public Employee( string name, int id)
        {
            Name = name;
            Id = id;
        }

        public abstract int CalculateSalary();
        public void DisplayWorkerInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}");
            Console.WriteLine($"Salary: {Salary} JD");
        }
    }
}
