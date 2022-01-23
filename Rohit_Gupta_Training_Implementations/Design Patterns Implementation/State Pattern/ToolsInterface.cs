using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.State_Pattern
{
    internal interface ToolsInterface
    {
        String getToolName();
        void mouseClicked();
        void mouseReleased();
    }
}
