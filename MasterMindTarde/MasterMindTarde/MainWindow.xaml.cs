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

namespace MasterMindTarde
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MMindManager manager = new MMindManager();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = manager;
        }

        private void Comprobar(object sender, RoutedEventArgs e)
        {
            int[] secuencia_jugador = new int[5];
            secuencia_jugador[0] = int.Parse(tb_celda_0.Text);
            secuencia_jugador[1] = int.Parse(tb_celda_1.Text);
            secuencia_jugador[2] = int.Parse(tb_celda_2.Text);
            secuencia_jugador[3] = int.Parse(tb_celda_3.Text);
            secuencia_jugador[4] = int.Parse(tb_celda_4.Text);
            
            tb_consola.Text = manager.Intentar(secuencia_jugador);

        }
    }
}
