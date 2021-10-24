using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Linq;

namespace Template
{
    public class VMModel
    {
        private ObservableCollection<Car> _cars = new ObservableCollection<Car>();
        public ObservableCollection<Car> Cars { get => _cars; }

        public void Load (string filename)
        {
            XDocument xDoc = XDocument.Load(filename);
                foreach (XElement element in xDoc.Element("Cars").Elements())
            {
                Cars.Add(new Car(xDoc.Element("Cars")));
            }
        }
        //public void AddCar(string brand,string model,string image)
        //{
        //    this.Cars.Add(new Car(model,brand,image));
        //public void Load()
        //{
        //    XDocument xDoc = XDocument.Load("XMLFile1.xml");
        //    foreach (XElement phoneElement in xDoc.Element("Cars").Elements("Car"))
        //    {
        //        XAttribute modelAttribute = phoneElement.Attribute("modelName");
        //        XAttribute companyElement = phoneElement.Attribute("company");
        //        XAttribute imageElement = phoneElement.Attribute("image");


        //        //if (nameAttribute != null && companyElement != null && priceElement != null)
        //        //{
        //        //    Console.WriteLine($"Смартфон: {nameAttribute.Value}");
        //        //    Console.WriteLine($"Компания: {companyElement.Value}");
        //        //    Console.WriteLine($"Цена: {priceElement.Value}");
        //        //}
        //        //Console.WriteLine();
        //    }
        //    Cars = new ObservableCollection<Car>{ new Car("logan","renault", Directory.GetCurrentDirectory()+"\\renault.jpg"),
        //        new Car("camry","toyota", Directory.GetCurrentDirectory()+@"\toyota.jpg"),
        //        new Car ("vesta","lada",Directory.GetCurrentDirectory()+"\\lada_vesta.jpg"),
        //        new Car("DB9","Aston Martin",Directory.GetCurrentDirectory()+@"\astonmartin_db9.jpg")};
        //}
    }
}
