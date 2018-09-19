using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace CSHW11
{
    [Serializable]
    public class Square : Shape
    {
        double side;
        public Square() { }
        public Square(string name, double side) : base(name)
        {
            this.side = side;
            this.Name = name;
        }

        public override double Area()
        {
            return side * side;
        }

        public override double Perimeter()
        {
            return side * 4;
        }
    }
}
