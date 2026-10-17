using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    internal class PartTimeEmployee : Employee, IWorkable
    {
        private int _WorkingHours { get; set; }
        private int _HourPrice { get; set; }
        public PartTimeEmployee(string name, int id, int WorkingHours, int HourPrice    ) : base(name, id)
        {
            _WorkingHours = WorkingHours;
            _HourPrice = HourPrice;
        }

        public override int CalculateSalary()
        {
            Salary = _WorkingHours * _HourPrice;
            return Salary;
        }

        public void Work()
        {
            Console.WriteLine($"{Name} Type: Part-Time.");
        }
    }
}
