using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.IO;

namespace Template
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            VMModel vm = new VMModel();
            vm.Cars = new ObservableCollection<Car>{ new Car("logan","renault", Directory.GetCurrentDirectory()+"\\renault.jpg"), new Car("camry","toyota", Directory.GetCurrentDirectory()+"\\toyota.jpg")};
            carsList.ItemsSource = vm.Cars;
          
        }
        private void carsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Car car = (Car)carsList.SelectedItem;
            MessageBox.Show(car.ModelName);
        }
    }
}
