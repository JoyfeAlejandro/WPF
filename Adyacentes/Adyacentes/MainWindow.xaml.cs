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

namespace Adyacentes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int estadoCeldaNO = 0;
        int estadoCeldaNE = 0;
        int estadoCeldaSO = 0;
        int estadoCeldaSE = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        public int CambiarImagen(Button btn, int estadoCelda)
        {
            ImageBrush Brush = new ImageBrush();
            if (estadoCelda == 0)
            {
                estadoCelda = 1;
                Brush.ImageSource = new BitmapImage(new Uri("HexagonoAzul.jpg", UriKind.Relative));
            }
            else
            {
                estadoCelda = 0;
                Brush.ImageSource = new BitmapImage(new Uri("HexagonoRojo.jpg", UriKind.Relative));
            }
            btn.Background = Brush;

            return estadoCelda;
        }
        
        public void ClickNO(object sender, RoutedEventArgs e)
        {
            estadoCeldaNO = CambiarImagen(btnNO, estadoCeldaNO);
            estadoCeldaNE = CambiarImagen(btnNE, estadoCeldaNE);
            estadoCeldaSO = CambiarImagen(btnSO, estadoCeldaSO);
        }

        public void ClickNE(object sender, RoutedEventArgs e)
        {
            estadoCeldaNE = CambiarImagen(btnNE, estadoCeldaNE);
            estadoCeldaNO = CambiarImagen(btnNO, estadoCeldaNO);
            estadoCeldaSE = CambiarImagen(btnSE, estadoCeldaSE);
        }

        public void ClickSO(object sender, RoutedEventArgs e)
        {
            estadoCeldaSO = CambiarImagen(btnSO, estadoCeldaSO);
            estadoCeldaNO = CambiarImagen(btnNO, estadoCeldaNO);
            estadoCeldaSE = CambiarImagen(btnSE, estadoCeldaSE);
        }

        public void ClickSE(object sender, RoutedEventArgs e)
        {
            estadoCeldaSE = CambiarImagen(btnSE, estadoCeldaSE);
            estadoCeldaNE = CambiarImagen(btnNE, estadoCeldaNE);
            estadoCeldaSO = CambiarImagen(btnSO, estadoCeldaSO);
        }
    }
}
