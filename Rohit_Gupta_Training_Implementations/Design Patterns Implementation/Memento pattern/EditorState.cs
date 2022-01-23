using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Memento_pattern
{
    internal class EditorState
    {

        private String content;
        private String title;

        public EditorState(string content, String title)
        {
            this.content = content;
            this.title = title;
        }

        public String getContent() 
        {
            return content;
        }

        public String getTitle() { return title; }


    }
}
