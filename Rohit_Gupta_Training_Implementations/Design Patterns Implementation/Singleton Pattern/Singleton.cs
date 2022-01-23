using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Singleton_Pattern
{
    internal sealed class Singleton
    {
        static private int Count=0;
        static private Singleton instance=null;

        public int getCount() { 
        
        return Count;
        }

        private Singleton() { }

        public static Singleton getInstance()
        {
            if (instance == null) {

                Count++;
                instance = new Singleton(); 
            }
            return instance;
        }
    }
}
