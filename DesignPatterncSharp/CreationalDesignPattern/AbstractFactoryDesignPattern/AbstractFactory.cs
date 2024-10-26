using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterncSharp.CreationalDesignPattern.AbstractFactoryDesignPattern
{
    public interface FurnitureFactory
    {
        Chair GetChair();

        Sofa GetSofa();
    }

    public interface Chair
    {

    }

    public interface Sofa
    {

    }

    public class VictorianChair : Chair
    {

    }

    public class ModernChair : Chair { 
    
    }

    public class VictorianSofa : Sofa
    {
    }

    public class ModernSofa : Sofa { 
    }


    public class VictorianFurnitureFactory : FurnitureFactory
    {
        public Chair GetChair()
        {
            return new VictorianChair();
        }

        public Sofa GetSofa()
        {
            return new VictorianSofa();
        }
    }

    public class ModernFurnitureFactory : FurnitureFactory
    {
        public Chair GetChair()
        {
            return new ModernChair();
        }

        public Sofa GetSofa()
        {
            return new ModernSofa();
        }
    }

    public class ProgramAbdtractClass
    {
        void main()
        {
            FurnitureFactory factory = new VictorianFurnitureFactory();
            factory.GetChair();
            factory.GetSofa();
        }
    }
}
