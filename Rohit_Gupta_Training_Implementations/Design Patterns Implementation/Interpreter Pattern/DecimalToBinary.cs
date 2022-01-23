using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Interpreter_Pattern
{
    internal class DecimalToBinary : Pattern
    {
        int data;
        String ans="";

        public DecimalToBinary(int data)
        {
            this.data = data;
        }

        public string getConversion()
        {
           for (int i = 0; data>0; i++)
            {
                ans=ans+ (data%2).ToString();
                data=data/2;
            }

           char[] _ans=ans.ToCharArray();
           Array.Reverse(_ans);

           return new string(_ans);
        }
    }
}
