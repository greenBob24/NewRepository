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
using System.Windows.Shapes;


namespace Template
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        private VMModel _vm;

        public AddWindow(VMModel vm)
        {
            InitializeComponent();
            _vm = vm;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            _vm.AddCar(addBrandTextBox.Text, addModelTextBox.Text, "");
            this.Close();
        }

        //private void addButton_Click(object sender, RoutedEventArgs e)
        //{
        //    _vm.AddCar(addBrandTextBox.Text, addModelTextBox.Text, "");
        //    this.Close();
        //}
    }
}
