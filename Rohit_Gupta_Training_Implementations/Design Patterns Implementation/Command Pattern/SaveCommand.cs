using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Command_Pattern
{
    internal class SaveCommand : Command
    {
        DOC doc;

        public SaveCommand(DOC doc)
        {
            this.doc = doc;
        }

        public void Execute()
        {
            doc.save();
        }
    }
}
