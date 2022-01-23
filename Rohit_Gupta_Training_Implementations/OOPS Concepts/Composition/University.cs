using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts.Composition
{
    internal class University
    {
        private string _name;
        private List<Departments> _departments=new List<Departments>();

        public University(string name)
        {
            _name = name;
        }

        public string getName() { return _name; }

        public void addDepartment(Departments departments)
        {
            if (!_departments.Contains(departments))
            {
                _departments.Add(departments);
            }
        }

        public void getDepartments()
        {
            Console.WriteLine("Departments under "+this._name);
            foreach(Departments de in _departments)
            {
                Console.WriteLine(de.getName());
            }
        }
    }
}
