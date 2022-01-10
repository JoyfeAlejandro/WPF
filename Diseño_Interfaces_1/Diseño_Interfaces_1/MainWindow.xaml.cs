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

namespace Diseño_Interfaces_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //Coche car = new Coche();

            //car.Modelo = "Ferrari";
            //car.Actualizar_kilometros(100);


            //MessageBox.Show("Mi " + car.Modelo + " ha recorrido " + car.Kilometros + "km"); // printf de cs
            
            InitializeComponent();
        }

        private void Al_Login(object sender, RoutedEventArgs e)
        {
            Ventanote Login = new Ventanote();
            Login.Show();
            this.Close();
        }

        private void Al_Register(object sender, RoutedEventArgs e)
        {
            Ventanote2 Register = new Ventanote2();
            Register.Show();
            this.Close();
        }
    }
}
