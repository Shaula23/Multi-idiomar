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
using System.Resources;

namespace AppMultiLenguaje
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Set_Lenguage();
        }
        private void ddlLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Set_Lenguage();
        }
        private void Set_Lenguage()
        {
            strLenguage = "Multilenguaje.Lenguajes." + ((ComboBoxItem)
                ddlLanguage.SelectedItem).Name.ToString();
            ResourceManager LocRM = new ResourceManager
                (strLenguage, typeof(MainWindow).Assembly);
            lblNombre.Text = LocRM.GetString("strNombre");
            lblEstudio.Text = LocRM.GetString("strEstudio");
            lblEscuela.Text = LocRM.GetString("strEscuela");
        }

    }
}
    }
}
