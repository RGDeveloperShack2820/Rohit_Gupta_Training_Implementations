﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts.Composition
{
    internal class Departments
    {
        private string name;

        public Departments(string name)
        {
            this.name = name;
        }

        public string getName() { return name; }
    }
}
