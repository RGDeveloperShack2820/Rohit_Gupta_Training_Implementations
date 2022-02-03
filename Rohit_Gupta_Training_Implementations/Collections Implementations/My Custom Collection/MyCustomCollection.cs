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

            RohitCollection<Monuments> rg=new RohitCollection<Monuments>();

            

            Console.WriteLine("Default Capacity : "+rg.Capacity+"\n");

            Console.Write(m1.Name);
            rg.Add(m1);
            Console.Write(m2.Name);
            rg.Add(m2);
            Console.Write(m3.Name);
            rg.Add(m3);

            Console.Write(m4.Name);
            rg.Add(m4);

            Console.Write(m4.Name);
            rg.Remove(3);

            Console.Write(m3.Name);
            rg.Remove(2);

            Console.Write(m2.Name);
            rg.Remove(1);

           
            RohitCollection<Monuments> rg1 = new RohitCollection<Monuments>(1);


            Console.WriteLine("\nNew Collection made with Capacity : 1\n");

            Console.WriteLine("Default Capacity : " + rg1.Capacity + "\n");

            Console.Write(m1.Name);
            rg1.Add(m1);
            Console.Write(m2.Name);
            rg1.Add(m2);

            rg1.CanExtend=true;
            Console.WriteLine("\nGiven Permission to Extend\n");

            Console.Write(m2.Name);
            rg1.Add(m2);
            

            Console.Write(m3.Name);
            rg1.Add(m3);
            Console.Write(m4.Name);
            rg1.Add(m4);


            Console.Write(m3.Name);
            rg1.Update(2, m4);

            foreach (Monuments item in rg1)
            {
                Console.WriteLine($"\nName : {item.Name} | Location : {item.Location}");
            }

            Console.WriteLine();
            rg.Add(m2);
            rg.Add(m3);
            rg.Add(m4);
            
            Console.WriteLine("\nComparison Implementation\n");

            Console.WriteLine("rg CompareTo rg1 : "+rg.CompareTo(rg1));
            Console.WriteLine("rg Equals rg1 : "+rg.Equals(rg1));

            rg1.Update(2, m3);

            Console.WriteLine("rg Equals rg1 : " + rg.Equals(rg1));

            Console.WriteLine("\nrg CompareTo rg : " + rg.CompareTo(rg));
            Console.WriteLine("rg Equals rg : " + rg.Equals(rg));

        }
    }
}
