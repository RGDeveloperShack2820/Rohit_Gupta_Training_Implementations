using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Design_Patterns_Implementation.Strategy_Pattern
{
    internal class Scooter
    {
        string paint;
        int noOfDents;

        public Scooter(string paint, int noOfDents)
        {
            this.paint = paint;
            this.noOfDents = noOfDents;
        }

        public string getPaint()
        {
            return paint;
        }

        public int getNoOfDents()
        {
            return noOfDents;
        }

        public void setPaint(string paint) {
        
            this.paint= paint;
        }

        public void setNoOfDents(int dents)
        {

            this.noOfDents = dents;
        }
    }
}
