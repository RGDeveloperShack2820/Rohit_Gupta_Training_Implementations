using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.OOPS_Concepts.Polymorphism
{

    class WritingClass
    {
        public virtual void write()
        {
            Console.WriteLine("Writing");
        }
    }

    class Marker : WritingClass
    {
        public override void write()
        {
            Console.WriteLine("Marker Writing");
        }
    }

    internal class Overriding
    {
        public void execute()
        {
            WritingClass w=new WritingClass();
            w.write();

            Marker marker=new Marker();
            marker.write();

            WritingClass w2=new Marker();
            w2.write();
        }
    }
}
