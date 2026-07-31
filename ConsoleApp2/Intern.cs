using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Intern : Employee
    {
        public Intern(int baseSalary, string name, int emplyeeId) : base(baseSalary, name, emplyeeId)
        {
        }

        public override decimal ClaculateSalary()
        {
            return (BaseSalary * 0.5m);
        }
        public override string ToString()
        {
            return $"name: {Name}, BaseSalary: {BaseSalary}, employeeId: {EmplyeeId}";
        }
    }
}
