using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Manager : Employee, IBonusEligible
    {
        public Manager(int baseSalary, string name, int emplyeeId, int teamSize) : base(baseSalary, name, emplyeeId)
        {
            TeamSize = teamSize;
        }

        int TeamSize {  get; set; }

        public decimal CalculateBonus()
        {
            return ((0.1m * BaseSalary) + (50 * TeamSize));
        }

        public override decimal ClaculateSalary()
        {
            return (BaseSalary + (TeamSize * 100));
        }

        public override string ToString()
        {
            return $"name: {Name}, BaseSalary: {BaseSalary}, employeeId: {EmplyeeId}, team size: {TeamSize}";
        }
    }
}
