using System;
using System.Xml;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xml_Doc = new XmlDocument();
            xml_Doc.Load("test.xml");
            XmlElement xml_Root = xml_Doc.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xml_Root)
            {
                XmlNode main_attr = xnode.Attributes.GetNamedItem("name");
                Console.WriteLine(main_attr.Value);

                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "resolution")
                        Console.WriteLine($"Разрешение: {childnode.InnerText}");

                    if (childnode.Name == "price")
                        Console.WriteLine($"Цена: {childnode.InnerText}");
                }
                Console.WriteLine();
            }
        }
    }
}
