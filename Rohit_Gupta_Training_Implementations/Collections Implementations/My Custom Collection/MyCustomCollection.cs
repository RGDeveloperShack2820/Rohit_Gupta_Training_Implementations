using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohit_Gupta_Training_Implementations.Collections_Implementations.My_Custom_Collection
{
    internal class MyCustomCollection
    {
        public void execute()
        {
            Monuments m1 = new Monuments("Taj Mahal","INDIA");
            Monuments m2 = new Monuments("Eiffel Tower","PARIS");
            Monuments m3 = new Monuments("Big Ben","LONDON");
            Monuments m4 = new Monuments("Pyramid","EGYPT");

            RohitCollection rg=new RohitCollection();

            Console.WriteLine("Default Capacity : "+rg.Capacity+"\n");

            rg.Add(m1);
            rg.Add(m2);
            rg.Add(m3);

            Console.WriteLine("Updated Capacity : " + rg.Capacity+"\n");

            rg.Add(m4);

            rg.Remove(3);

            Console.WriteLine("Updated Capacity : " + rg.Capacity+"\n");

            rg.Add(m4);

            Console.WriteLine("Updated Capacity : " + rg.Capacity + "\n");

            RohitCollection rg1=new RohitCollection(1);

            Console.WriteLine("New Collection made with Capacity : 1\n");

            Console.WriteLine("Default Capacity : " + rg1.Capacity + "\n");

            rg1.Add(m1);
            rg1.Add(m2);

            rg1.CanExtend=true;
            Console.WriteLine("Given Permission to Extend\n");

            rg1.Add(m2);
            

            Console.WriteLine("Updated Capacity : " + rg1.Capacity + "\n");

            rg1.Add(m3);
            rg1.Add(m4);

            Console.WriteLine("Updated Capacity : " + rg1.Capacity + "\n");

            rg1.Update(2, m4);

            foreach (Monuments item in rg1)
            {
                Console.WriteLine($"\nName : {item.Name} | Location : {item.Location}");
            }

        }
    }
}
