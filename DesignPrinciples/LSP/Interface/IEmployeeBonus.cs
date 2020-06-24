using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.LSP.Interface
{
    interface IEmployeeBonus
    {

        decimal CalculateBonus(decimal salary);
    }
}
