using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.SOLID_KISS_DRY_YAGNI_Principles.DRY_Principle
{
    internal class DepartmentInfo
    {
       static void CSE()
        {
            Console.WriteLine("Computer Science & Engineering Branch");
            college();
        }

        static void IT()
        {
            Console.WriteLine("Information Technology Branch");
            college();
        }

        static void college()
        {
            Console.WriteLine("Dronacharya College Of Engineering");
        }

        public static void execute()
        {
            CSE();
            IT();
        }
    }
}
