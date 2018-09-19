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
    public abstract class Shape
    {
        public Shape() { }
        public Shape(string _name)
        {
            name = _name;
        }
        string name;
        public string Name { get; set; }
        public abstract double Area();
        public abstract double Perimeter();
    }
}
