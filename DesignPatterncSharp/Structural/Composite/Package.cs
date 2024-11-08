using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterncSharp.Structural.Composite
{
    public interface IOrder
    {
        int CalculatePrice();
    }

    public class Package : IOrder
    {

        public List<IOrder> Packages = [];
        public int CalculatePrice()
        {
            var price = 0;

            for (int i = 0; i < Packages.Count; i++) { 
                price += Packages[i].CalculatePrice();
            
            }

            return price;
        }
    }

    public class Item : IOrder
    {
        public int CalculatePrice()
        {
            return 100;
        }
    }
}
