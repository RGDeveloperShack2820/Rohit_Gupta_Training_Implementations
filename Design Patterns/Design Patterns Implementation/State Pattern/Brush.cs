using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.State_Pattern
{
    internal class Brush : ToolsInterface
    {
       
        public string getToolName()
        {
            return "Brush";
        }

        public void mouseClicked()
        {
            Console.WriteLine("Brush Clicked");
        }

        public void mouseReleased()
        {
            Console.WriteLine("Brush Released");
        }
    }
}
