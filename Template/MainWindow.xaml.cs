﻿using System;
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
        public VMModel vm = new VMModel();
        public string model;
        public string brand;
        public string path;

        public MainWindow()
        {
            InitializeComponent();
            vm.Cars = new ObservableCollection<Car>{ new Car("logan","renault", Directory.GetCurrentDirectory()+"\\renault.jpg"), 
                new Car("camry","toyota", Directory.GetCurrentDirectory()+@"\toyota.jpg"),
                new Car ("vesta","lada",Directory.GetCurrentDirectory()+"\\lada_vesta.jpg"),
                new Car("DB9","Aston Martin",Directory.GetCurrentDirectory()+@"\astonmartin_db9.jpg")};
            carsList.ItemsSource = vm.Cars;
          
        }
        private void carsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Car car = (Car)carsList.SelectedItem;
            MessageBox.Show(car.ModelName);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addwindow = new AddWindow();
            addwindow.Show();


        }
    }
}
