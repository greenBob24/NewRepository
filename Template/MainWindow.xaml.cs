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
using System.Xml.Linq;

namespace Template
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private VMModel vm = new VMModel();
        //public string model;
        //public string brand;
        //public string path;

        public MainWindow()
        {
            InitializeComponent();
            string path = Directory.GetCurrentDirectory();
            int index = path.IndexOf("bin\\Debug");
            path = path.Substring(0, index);
            vm.Load(path+"XMLFile2.xml");
            carsList.ItemsSource = vm.Cars;

        }
        //private void carsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    Car car = (Car)carsList.SelectedItem;
        //    MessageBox.Show(car.ModelName);   
        //}

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addwindow = new AddWindow(vm);
            addwindow.ShowDialog();

        }
    }
}
