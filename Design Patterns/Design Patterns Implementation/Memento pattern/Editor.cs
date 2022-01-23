using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Memento_pattern
{
    internal class Editor
    {
       private String content;
        private String title;

       public String getContent() { return content; }
        public String getTitle() { return title; }

       public void setContent(String content) 
        
        { 
            this.content = content;
            
        }
        public void setTitle(String title)

        {
            this.title = title;

        }


        public EditorState createState() 
       {
            return new EditorState(content , title);   
       }

       public void restore(EditorState state) 
       {
            content = state.getContent();
            title = state.getTitle();
       }
        
    }
}
