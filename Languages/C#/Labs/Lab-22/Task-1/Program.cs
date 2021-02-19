using System;
using System.Xml.Linq;
using System.Collections.Generic;

namespace Task_1
{
    class Camera
    {
        public string name { get; }
        public string resolution { get; }
        public string price { get; }

        public Camera(string _name, string _resolution, string _price)
        {
            name = _name;
            resolution = _resolution;
            price = _price;
        }

        public void Show()
        {
            Console.WriteLine($"Имя: {name}\nРазрешение: {resolution}\nЦена: {price}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Camera> cameras = new List<Camera>();
            for (int i = 0; i < 2; i++)
                cameras.Add(new Camera(Console.ReadLine(), Console.ReadLine(), Console.ReadLine()));

            foreach (Camera i in cameras)
            {
               i.Show();
            }

            XDocument xdoc = new XDocument();
            XElement cameras_ = new XElement("cameras");

            foreach (Camera cam in cameras)
            {
                XElement camera_ = new XElement("Camera");

                XAttribute name = new XAttribute(new XAttribute("name", cam.name));
                XElement resolution = new XElement(new XElement("resolution", cam.resolution));
                XElement price = new XElement(new XElement("price", cam.price));

                camera_.Add(name);
                camera_.Add(resolution);
                camera_.Add(price);

                cameras_.Add(camera_);

            }
            xdoc.Add(cameras_);
            xdoc.Save("new_file.xml");
        }
    }
}
