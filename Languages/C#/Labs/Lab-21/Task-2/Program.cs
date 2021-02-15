using System;
using System.Xml;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xml_Doc = new XmlDocument();
            xml_Doc.Load(@"R:\GitHub\learning\Languages\C#\Labs\Lab-21\Task-1\test.xml");

            XmlElement xml_Root = xml_Doc.DocumentElement;
            XmlElement userElem = xml_Doc.CreateElement("analog");
            XmlAttribute camera_name = xml_Doc.CreateAttribute("name");
            XmlElement camera_resolution = xml_Doc.CreateElement("resolution");
            XmlElement camera_price = xml_Doc.CreateElement("price");

            XmlText nameText = xml_Doc.CreateTextNode("Tesk-1");
            XmlText companyText = xml_Doc.CreateTextNode("900x900");
            XmlText ageText = xml_Doc.CreateTextNode("99999 BYN");

            camera_name.AppendChild(nameText);
            camera_resolution.AppendChild(companyText);
            camera_price.AppendChild(ageText);
            userElem.Attributes.Append(camera_name);
            userElem.AppendChild(camera_price);
            userElem.AppendChild(camera_resolution);

            xml_Root.AppendChild(userElem);
            xml_Doc.Save("test1.xml");

        }
    }
}
