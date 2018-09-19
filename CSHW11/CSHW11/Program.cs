using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace CSHW11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Square("sqr1", 2));
            shapes.Add(new Square("sqr2", 5));
            shapes.Add(new Square("sqr3", 3));

            shapes.Add(new Circle("cir1", 28));
            shapes.Add(new Circle("cir2", 7));
            shapes.Add(new Circle("cir3", 9));
            Circle circle = new Circle("cir1", 28);



            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("shapes.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, circle);
            }

            XmlSerializer XMLformatter = new XmlSerializer(typeof(Circle));

            using (FileStream fs = new FileStream("XMLshapes.xml", FileMode.OpenOrCreate))
            {
                XMLformatter.Serialize(fs, circle);
            }

        }
    }
}
