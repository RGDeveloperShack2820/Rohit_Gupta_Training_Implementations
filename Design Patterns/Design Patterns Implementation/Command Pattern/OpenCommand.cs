using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Command_Pattern
{
    internal class OpenCommand : Command
    {
        DOC doc;

        public OpenCommand(DOC doc)
        {
            this.doc = doc;
        }

        public void Execute()
        {
           doc.open();
        }
    }
}
