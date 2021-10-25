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
        private string fileName;
        private XElement helpXElement;

        public void Load(string filename)
        {
            fileName = filename;
            XDocument xDoc = XDocument.Load(filename);
            foreach (XElement element in xDoc.Element("Cars").Descendants())
            {
                Cars.Add(new Car(element));
                helpXElement = element;
            }
        }
        public void AddCar(string brand, string model, string image)
        {
            helpXElement.Attribute("modelName").Value = brand;
            helpXElement.Attribute("company").Value = model;
            helpXElement.Attribute("image").Value = image;
            XDocument xDoc = XDocument.Load(fileName);
            xDoc.Element("Cars").Add(helpXElement);
            xDoc.Save(fileName);
            Cars.Add(new Car(helpXElement));
        }
    }
}
