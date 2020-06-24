using DesignPrinciples.LSP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.LSP.Abstract
{
    public abstract class Employee : IEmployee, IEmployeeBonus
    {
        public abstract decimal CalculateBonus(decimal salary);


        public abstract decimal GetMinimumSalary();
        
    }
}
