using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.SOLID_Principles.K.I.S.S_principle
{
    internal class KISSPrinciple
    {
        //Complex Implementation
        public String getweekday1(int day)
        {
            switch (day)
            {
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                case 7:
                    return "Sunday";
                default:
                    Console.WriteLine("day must be in range 1 to 7");
                    return null;
            }
        }

        //Simple Implementation
        public String getweekday2(int day)
        {
            if (!(day < 1) || (day > 7))
            {
                string[] days = {
                            "Monday",
                            "Tuesday",
                            "Wednesday",
                            "Thursday",
                            "Friday",
                            "Saturday",
                            "Sunday"
                             };

                return days[day - 1];
            }

            Console.WriteLine("day must be in range 1 to 7");
            return null;
        }
    }
}
