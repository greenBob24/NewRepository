using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Template
{
    public class Car
    {
        private string modelName;
        private string company;
        private string imageOfCar;
        public string ModelName
        {
            get => modelName;
            set
            {
                if (modelName != value)
                {
                    modelName = value;
                }
            }
        }
        public string Company {
            get => company;
            set
            {
                if (company != value)
                {
                    company = value;
                }
            }
        }
        public string ImageOfCar {
            get => imageOfCar;
            set
            {
                if (imageOfCar != value)
                {
                    imageOfCar = value;
                }
            }
        }

        public Car(XElement el)
        {
            ModelName = (string)el.Attribute("modelName");
            Company = (string)el.Attribute("company");
            ImageOfCar = (string)el.Attribute("image");
        }
    }
}
