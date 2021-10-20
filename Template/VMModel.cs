using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Template
{
    class VMModel
    {
        public ObservableCollection<Car> Cars { get; set; }
        public void AddCar(string brand,string model,string image)
        {
            this.Cars.Add(new Car(model,brand,image));
        }

    }
}
