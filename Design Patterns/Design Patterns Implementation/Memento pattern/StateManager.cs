using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Memento_pattern
{
    internal class StateManager
    {
        private Stack<EditorState> states = new Stack<EditorState>();

        public void push(EditorState state) 
        {
            states.Push(state);
        }

        public EditorState pop()
        {
          return states.Pop();
        }

    }
}
