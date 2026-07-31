using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public abstract class Employee
    {
        private int baseSalary;

        protected Employee(int baseSalary, string name, int emplyeeId)
        {
            BaseSalary = baseSalary;
            Name = name;
            EmplyeeId = emplyeeId;
        }

        public string Name { get; }
        public int EmplyeeId { get;  }

        public int BaseSalary
        {
            get => baseSalary; set
            {
                if (value <= 0)
                {
                    Console.WriteLine("rejected, negative salary");
                }
                else
                {
                    baseSalary = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Employee name: {Name}, BaseSalary: {BaseSalary}, Emplyee ID: {EmplyeeId}";
        }

        public abstract decimal ClaculateSalary();

    }
}
