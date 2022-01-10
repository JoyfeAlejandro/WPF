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

namespace Enunciado2122P1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BoleraManager manager = new BoleraManager();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = manager;
        }
        public void Lanzar_Click(object sender, RoutedEventArgs e)
        {
            
            if (manager.TiradaActual < 11)
            {
                bool[] resultado = manager.Lanzar((int)sld_linea.Value, (int)sld_energia.Value);
                RefrescarYPintar();

                if (manager.IntentoActual == 1)
                    manager.IntentoActual = 2;
                else
                {
                    manager.IntentoActual = 1;
                    manager.TiradaActual++;
                    manager.ReponerBolos();
                }
            }
            else
            {
                MessageBox.Show("Se acabo la partida, comienza una nueva!");

                manager.Partida++;
                manager.TiradaActual = 1;
                for (int i = 0; i < 10; i++)
                {
                    manager.Marcador.ElementAt(i).Intento1 = 0;
                    manager.Marcador.ElementAt(i).Intento2 = 0;
                    manager.Marcador.ElementAt(i).TiradaResultado = 0;
                }
            }
        }

        private void RefrescarYPintar()
        {
            ////REFRESCAR IMAGEN Y PINTAR

            SolidColorBrush colorTirado = new SolidColorBrush();
            colorTirado.Color = Colors.OrangeRed;
            SolidColorBrush colorEnPie = new SolidColorBrush();
            colorEnPie.Color = Colors.WhiteSmoke;

            e_bolo_1.Fill = colorEnPie;
            e_bolo_2.Fill = colorEnPie;
            e_bolo_3.Fill = colorEnPie;
            e_bolo_4.Fill = colorEnPie;
            e_bolo_5.Fill = colorEnPie;
            e_bolo_6.Fill = colorEnPie;
            e_bolo_7.Fill = colorEnPie;
            e_bolo_8.Fill = colorEnPie;
            e_bolo_9.Fill = colorEnPie;
            e_bolo_10.Fill = colorEnPie;

            for (int i = 0; i < 10; i++)
            {
                if (manager.Bolos[i] && i == 0)
                    e_bolo_1.Fill = colorTirado;
                if (manager.Bolos[i] && i == 1)
                    e_bolo_2.Fill = colorTirado;
                if (manager.Bolos[i] && i == 2)
                    e_bolo_3.Fill = colorTirado;
                if (manager.Bolos[i] && i == 3)
                    e_bolo_4.Fill = colorTirado;
                if (manager.Bolos[i] && i == 4)
                    e_bolo_5.Fill = colorTirado;
                if (manager.Bolos[i] && i == 5)
                    e_bolo_6.Fill = colorTirado;
                if (manager.Bolos[i] && i == 6)
                    e_bolo_7.Fill = colorTirado;
                if (manager.Bolos[i] && i == 7)
                    e_bolo_8.Fill = colorTirado;
                if (manager.Bolos[i] && i == 8)
                    e_bolo_9.Fill = colorTirado;
                if (manager.Bolos[i] && i == 9)
                    e_bolo_10.Fill = colorTirado;
            }
        }
    }
}
