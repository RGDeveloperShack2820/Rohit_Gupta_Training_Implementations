using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Implementation.Mediator_Pattern
{
    internal class User
    {
        private String name;

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public User(String name)
        {
            this.name = name;
        }

        public void sendMessage(String message)
        {
            ChatRoom.showMessage(this, message);
        }
    }
}
