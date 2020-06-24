using DesignPrinciples.LSP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.LSP.Implementation
{
    class ContactEmployee : IEmployee
    {
        public decimal GetMinimumSalary()
        {
            return 10000;
        }
    }
}
