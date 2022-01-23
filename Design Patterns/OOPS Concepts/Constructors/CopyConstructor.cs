using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.OOPS_Concepts.Constructors
{
    class Subject
    {
        string name;
        int marks;
        public Subject() { }
        public Subject(Subject subject)
        {

            this.name=subject.name;
            this.marks=subject.marks;
        }

        public string getName() { return name; }
        public int getMarks() { return marks; }

        public void setName(string name) { this.name = name;}
        public void setMarks(int marks) { this.marks = marks;}
    }
    internal class CopyConstructor
    {
       
        public void execute()
        {
            Subject subject1 = new Subject();
            subject1.setName("Science");
            subject1.setMarks(100);

            Subject subject2 = new Subject(subject1);

            Console.WriteLine($"Subject 1 : {subject1.getName() }| Marks : {subject1.getMarks()}" );
            Console.WriteLine($"Subject 2 : {subject2.getName() }| Marks : {subject2.getMarks()}" );
        }

    }
}
