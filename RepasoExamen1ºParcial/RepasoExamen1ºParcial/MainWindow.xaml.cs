using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace RepasoExamen1ºParcial
{
    public partial class MainWindow : Window
    {
        Manager manager = new Manager();
        public MainWindow()
        {
            InitializeComponent();

            manager.AñadirMensaje("Primer texto de ejemplo");

            DataContext = manager;
        }

        private void Añadir_Click(object sender, RoutedEventArgs e)
        {
            manager.AñadirMensaje(tbContenido.Text);
            MessageBox.Show("Mensaje añadido a la lista");
        }

        // int.Parse(tbAnno.Text) Para pasar a int
    }
}
