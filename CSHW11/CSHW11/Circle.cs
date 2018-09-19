using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace CSHW11
{
    [Serializable]
    public class Circle : Shape
    {
        double radius;
        public Circle() { }
        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
            this.Name = name;
        }

        public override double Area()
        {
            return (2 * Math.PI * radius);
        }

        public override double Perimeter()
        {
            return (Math.PI * Math.Pow(radius, 2));
        }
    }
}
