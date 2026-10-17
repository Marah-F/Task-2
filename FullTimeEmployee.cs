using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    internal class FullTimeEmployee : Employee, IWorkable
    {
        private int _MonthlySalary {  get; set; }
        public FullTimeEmployee(string name, int id, int MonthlySalary  ) : base(name, id)
        {
            _MonthlySalary = MonthlySalary;
        }

        public override int CalculateSalary()
        {
            Salary = _MonthlySalary;
            return Salary;
        }

        public void Work()
        {
            Console.WriteLine($"{Name} Type: Full-Time.");
        }
    }
}
