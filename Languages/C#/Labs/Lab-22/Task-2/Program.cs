using System;
using System.Xml.Linq;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {

            XDocument xdoc = XDocument.Load("new_file.xml");
            XElement root = xdoc.Element("cameras");

            foreach (XElement phoneElement in xdoc.Element("cameras").Elements("Camera"))
            {
                XAttribute name = phoneElement.Attribute("name");
                XElement resolution = phoneElement.Element("resolution");
                XElement price = phoneElement.Element("price");

                Console.WriteLine($"Имя: {name.Value}");
                Console.WriteLine($"Разрешение: {resolution.Value}");
                Console.WriteLine($"Цена: {price.Value}");

                Console.WriteLine();
            }

            root.Add(new XElement("Camera",
                new XAttribute("name", "new_test"),
                new XElement("resolution", "1111111"),
                new XElement("price", "19500")));
            xdoc.Save("new_file1.xml");

        }
    }
}
