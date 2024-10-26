using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterncSharp.CreationalDesignPattern.FactoryDesignPattern
{
    public abstract class Creator
    {
        public abstract IProduct CreateProduct();
    }

    public class CreatorA : Creator
    {
        public override IProduct CreateProduct()
        {
            return new ProductA();
        }
    }

    public class CreatorB : Creator
    {
        public override IProduct CreateProduct()
        {
            return new ProductB();
        }
    }

    public interface IProduct
    {
        void DoStuff();
    }

    public class ProductA : IProduct
    {
        public void DoStuff()
        {

        }
    }

    public class ProductB : IProduct
    {
        public void DoStuff()
        {

        }
    }

    public static class FactorySelector
    {
        public static Creator GetCreator(string type)
        {
            switch (type)
            {
                case "A":
                    return new CreatorA();
                case "B":
                    return new CreatorB();
                default:
                    throw new NotImplementedException();
            }


        }
    }
}
