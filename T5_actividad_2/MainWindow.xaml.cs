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

namespace T5_actividad_2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Plato> listaPlatos = Plato.GetSamples("/Resources");
        List<String> tipoComida = new List<String> { "China", "Americana", "Mexicana" };
        public MainWindow()
        {
            InitializeComponent();
            ListadoPlatos.DataContext = listaPlatos;
            tipo_ComboBox.ItemsSource = tipoComida;
        }
    }
}
