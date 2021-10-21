using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.IO;

namespace Template
{
    public class VMModel
    {
        public ObservableCollection<Car> Cars { get; set; }
        public void AddCar(string brand,string model,string image)
        {
            this.Cars.Add(new Car(model,brand,image));
        }
        public void Load()
        {
            Cars = new ObservableCollection<Car>{ new Car("logan","renault", Directory.GetCurrentDirectory()+"\\renault.jpg"),
                new Car("camry","toyota", Directory.GetCurrentDirectory()+@"\toyota.jpg"),
                new Car ("vesta","lada",Directory.GetCurrentDirectory()+"\\lada_vesta.jpg"),
                new Car("DB9","Aston Martin",Directory.GetCurrentDirectory()+@"\astonmartin_db9.jpg")};
        }
    }
}
