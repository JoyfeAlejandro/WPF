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

namespace Diseño_Interfaces_1
{
    /// <summary>
    /// Lógica de interacción para Ventanote2.xaml
    /// </summary>
    public partial class Ventanote2 : Window
    {
        public Ventanote2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Volver = new MainWindow();
            Volver.Show();
            this.Close();
        }
    }
}
