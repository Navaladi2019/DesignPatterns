using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.OCP
{
    /*
     * Instead of making an employee type variable and passing type we make base class and derived class for employee type so that adding new employee type does not make any changes in the existing type.Open for extension but closed for modification.
     
         
         
         */
  public abstract  class Employee
    {

        public Employee()
        {

        }

        public Employee(int Id, decimal salary)
        {
            this.salary = salary;
            this.Id = Id;
        }
        public int Id { get; set; }

        public string EmployeeName { get; set; }

        public decimal salary { get; set; }

        public abstract decimal getBonus();
    }

    public class PermanentEmployee : Employee
    {

        public PermanentEmployee(int Id,decimal salary)
        {
            this.salary = salary;
            this.Id = Id;

        }
        public override decimal getBonus()
        {
            return salary * 0.1M;                
        }
    }

    public class TemporaryEmployee : Employee
    {

        public TemporaryEmployee(int Id, decimal salary) : base(Id, salary)
        {
            

        }
        public override decimal getBonus()
        {
            return salary * 0.05M;
        }
    }

}

// suppose if i have DAO storing to db, but tomorrow i want to store it to file system also , 
//then touching the existing working class is wrong, so i can create a interface with save method and have it consumed by both filesave and db saver
