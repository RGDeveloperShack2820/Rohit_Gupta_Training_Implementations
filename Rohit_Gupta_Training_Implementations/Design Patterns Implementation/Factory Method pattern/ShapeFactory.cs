using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Factory_Method_pattern
{
    internal class ShapeFactory
    {
        public Shape getShape(String shapeName) {

            switch (shapeName) {

                case "Circle":
                    return new Circle();

                case "Rectangle":
                    return new Rectangle();

                case "Triangle":
                    return new Triangle();

            
            }

            return null;
        
        }
    }
}
