using DesignPrinciples.LSP.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.LSP.Implementation
{
    class TemporaryEmployee: Employee
    {
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * 0.5M;
        }

        public override decimal GetMinimumSalary()
        {
            return 15000;
        }
    }
}
