using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Command_Pattern
{
    internal class DocHandler
    {
        Command command;

        public DocHandler(Command command)
        {
            this.command = command;
        }

        public void  execute()
        {
            command.Execute();
        }
    }
}
