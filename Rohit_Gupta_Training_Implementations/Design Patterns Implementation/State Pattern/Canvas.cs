using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.State_Pattern
{
    internal class Canvas
    {
       private ToolsInterface tool;

        public void setTool(ToolsInterface tool)
        {
            this.tool = tool;
            Console.WriteLine("Tool: "+tool.getToolName());
        }

        public void mouseClicked() 
        {
            tool.mouseClicked();
        }

        public void mouseReleased()
        {
            tool.mouseReleased();
        }
    }
}
