using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Car
    {
        public string ModelName { get; set; }
        public string Company { get; set; }
        public string ImageOfCar { get; set; }

        public Car(string model="unknown",string company = "unknown",string image ="unknown")
        {
            ModelName = model;
            Company = company;
            ImageOfCar = image;
        }
        public Car() { }
    }
}
