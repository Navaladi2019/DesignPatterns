using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterncSharp.Structural.Proxy
{
    public interface IDbCall
    {
     public void  getRecord(string id);
    }

    public class DbCall : IDbCall
    {
        public void getRecord(string id)
        {
            Console.WriteLine("Getting records from DB");
        }
    }

    public class CacheDbCall : IDbCall
    {

        private DbCall dbCall;

        private object cache = new object();
        public void getRecord(string id)
        {
           //if cache has object the return cache value 
           // else if dbcall == null then create new instance and fetch from db and store it in cache and return value
        }
    }
}
