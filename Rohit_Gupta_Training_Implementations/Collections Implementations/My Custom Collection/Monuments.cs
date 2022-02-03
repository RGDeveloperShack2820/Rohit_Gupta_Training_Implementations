using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohit_Gupta_Training_Implementations.Collections_Implementations.My_Custom_Collection
{
    internal class Monuments  
    {
        string name;
        string location;

        public Monuments(string name, string location)
        {
            this.name = name;
            this.location = location;
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }


        public string Location
        {
            get { return location; }
            set { this.location = value; }
        }

      

      
    }
}
