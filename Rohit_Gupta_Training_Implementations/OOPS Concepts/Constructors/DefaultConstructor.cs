using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.OOPS_Concepts.Constructors
{
    class Entity
    {
        string name;

        public Entity()
        {
            name = "Default Name";
            Console.WriteLine($"Entity Name : {name} (Inside Default Constructor)");
        }
    }
    internal class DefaultConstructor
    {
        public void execute()
        {
            Entity entity = new Entity();
        }
    }
}
