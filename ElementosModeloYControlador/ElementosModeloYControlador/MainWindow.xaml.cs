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

namespace ElementosModeloYControlador
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Perfil perf = new Perfil();
 
        public MainWindow()
        {
            InitializeComponent();

            DataContext = perf;
        }
        public void Metodo_Click(object sender, RoutedEventArgs e)
        {
            perf.Nombre = "Juan";
            perf.ResolucionAltura = 500;
            perf.ResolucionAnchura = 500;
        }
        

    }

        
}
