using DesignPrinciples.OCP;
using System;

namespace DesignPrinciples
{
    class Program
    {

        // SOLID design principles
        //  --S -- Single responsibility Principle
        //  --O-- Open Closed Principle
        //  --L-- Liskov Substitution Principle
        //  --I-- Interface Segregation Principle
        //  --D-- Dependency Inversion Principle


        /* Single responsibility Principle 

            * Every Class or Module should have responsibilty over a single part of the functionality of software and
            that responsibility should be entirely encapsulated by the class 

        Liskov Substitution Principle

            * Objects in a program should be replacable with their instances of the subtype without affecting the correctness of the program
            * If a Program modeule is using a base class , then reference t the base class can be replaced with the derived class without altering the funtionality of the program module.
            * No new Exception should be thrown.

        Open Closed Principle
            * Software entities should be open for extension but closed for modification
            * The design and writing of the code should be in such a way that new funcyionality should be added with minimal changes in the existing code
       
        Interface Segregation Principle
            * Many client specific interfaces are better than one general purpose interface.
            * We should not enforce client to implement interfaces they don't use.Instead of using one big interface we can break down it to smaller interfaces. 


        Dependency Inversion Principle
            * One should depend upon abstractions and not concretions.
            * Abstraction should not depend on the details where as detail should depend on abstractions.
            * High-level modules should not depend on low level modules.


    */
        static void Main(string[] args)
        {
            Employee lEmployee = new TemporaryEmployee(1,10000);
            Console.WriteLine(lEmployee.getBonus());

            Employee lEmployeeT = new PermanentEmployee(1, 10000);
            Console.WriteLine(lEmployeeT.getBonus());
        }
    }
}
