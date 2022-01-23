using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Implementation.Mediator_Pattern
{
    internal class ChatRoom
    {
        public static void showMessage(User user, String message)
        {
            Console.WriteLine(" [" + user.getName() + "] : " + message);
        }
    }
}
