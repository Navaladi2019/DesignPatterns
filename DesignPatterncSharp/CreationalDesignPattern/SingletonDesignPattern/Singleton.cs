using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterncSharp.CreationalDesignPattern.SingletonDesignPattern
{

    //we are making this calss sealed because we do not want any nested calss in singleton class to inherit singleton class
  public sealed  class Singleton
    {

        private static int counter = 0;

        // A static read only field can be assigned in either variable initiaizaer or static constructor.
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(()=>new Singleton());

      
        private static readonly object obj = new object();

          
        public static Singleton GetInstance
        {
            get
            {
                //since initializing the instance obj in variable initialization C# itself handles thread safety.

                //lock (obj)
                //{
                //    if (instance == null)
                //        instance = new Singleton();
                //}

                return instance.Value;
            }
        }
     

        // if the constructor is private then this can only be accessed from nested class. So inheritance from outer class is not possible.
        private Singleton()
        {
            counter++;
        }
        public void PrintDetails(string Message)
        {

        }
    }
}
