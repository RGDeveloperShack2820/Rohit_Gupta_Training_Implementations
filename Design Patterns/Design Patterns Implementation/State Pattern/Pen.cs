using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.State_Pattern
{
    internal class Pen : ToolsInterface
    {
        public string getToolName()
        {
            return "Pen";
        }
        public void mouseClicked()
        {
            Console.WriteLine("Pen Clicked");
        }

        public void mouseReleased()
        {
            Console.WriteLine("Pen Released");
        }
    }
}
