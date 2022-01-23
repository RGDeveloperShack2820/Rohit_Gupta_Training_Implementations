﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Factory_Method_pattern
{
    internal class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }
}
