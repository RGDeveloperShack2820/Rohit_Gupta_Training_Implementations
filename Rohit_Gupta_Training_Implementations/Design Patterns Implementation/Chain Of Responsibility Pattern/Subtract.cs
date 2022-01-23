using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Chain_Of_Responsibility_Pattern
{
    internal class Subtract : Chain
    {
        Chain nextChain = null;
        public void performCalculation(Calculate data)
        {
            if (data.getCalculation() == "sub")
                Console.WriteLine($"{data.getNumber1()} - {data.getNumber2()} = {data.getNumber1() - data.getNumber2()}");
            else if (nextChain == null)
                Console.WriteLine(data.getCalculation() + " is Invalid Calculation Request");
            else
                nextChain.performCalculation(data);
        }

        public void setNextChain(Chain nextChain)
        {
            this.nextChain = nextChain;
        }
    }
}
