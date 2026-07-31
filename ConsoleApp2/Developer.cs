using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Developer : Employee, IBonusEligible
    {
        public Developer(int baseSalary, string name, int emplyeeId, string programmingL) : base(baseSalary, name, emplyeeId)
        {
            ProgrammingL = programmingL;
        }

        public string ProgrammingL {  get; set; }

        public decimal CalculateBonus()
        {
            return (0.05m * BaseSalary);
        }

        public override decimal ClaculateSalary()
        {
            return BaseSalary;
        }

        public override string ToString()
        {
            return $"name: {Name}, BaseSalary: {BaseSalary}, employeeId: {EmplyeeId}, Language: {ProgrammingL}";
        }
    }
}
