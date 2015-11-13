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
using MongoDBApp.ViewModels;
using MongoDBApp.Services;


namespace MongoDBApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView : Window
    {
        private MainViewModel ViewModel { get; set; }
        
        public MainView()
        {
            InitializeComponent();
            ViewModel = new MainViewModel(CustomerRepository.Instance);
            this.DataContext = ViewModel;

        }



       


    }
}
