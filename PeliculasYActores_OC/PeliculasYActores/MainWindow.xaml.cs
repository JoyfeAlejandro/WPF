using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace PeliculasYActores
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Pelicula> listaPeliculas = new ObservableCollection<Pelicula>();
        public MainWindow()
        {
            InitializeComponent();

            ObservableCollection<Actor> listaActoresBatman = new ObservableCollection<Actor>();
            //Actor miActor = new Actor("Christian Bale", string.Empty, 1974);
            //listaActoresBatman.Add(miActor);
            listaActoresBatman.Add(new Actor("Christian Bale", string.Empty, 1974));
            listaActoresBatman.Add(new Actor("Michael Caine", string.Empty, 1933));
            listaActoresBatman.Add(new Actor("Liam Neeson", string.Empty, 1952));
            listaActoresBatman.Add(new Actor("Katie Holmes", string.Empty, 1978));
            listaActoresBatman.Add(new Actor("Morgan Freeman", string.Empty, 1937));
            listaActoresBatman.Add(new Actor("Gary Oldman", string.Empty, 1958));

            ObservableCollection<Actor> listaActoresChicago = new ObservableCollection<Actor>();
            listaActoresChicago.Add(new Actor("Renée Zellweger", string.Empty, 1969));
            listaActoresChicago.Add(new Actor("Catherine Zeta-Jones", string.Empty, 1969));
            listaActoresChicago.Add(new Actor("Richard Gere", string.Empty, 1949));
            listaActoresChicago.Add(new Actor("John C. Reilly", string.Empty, 1965));

           
            listaPeliculas.Add(new Pelicula("Batman Begins", "Inicio de la nueva saga de Batman", 2005, listaActoresBatman));
            listaPeliculas.Add(new Pelicula("Chicago", "Musical sobre dos reclusas en los años 20", 2002, listaActoresChicago));

            //IMPORTANTE
            //DataContext es la cache de la aplicación, un recipiente que toda la aplicación puede ver. Puede ser cualquier cosa
            //Desde cualquier lado puedes ver el DataContext con el {Binding}
            DataContext = listaPeliculas;
        }
        private void btnAddPeli_Click(object sender, RoutedEventArgs e)
        {
            listaPeliculas.Add(new Pelicula(tbTitulo.Text, tbDesc.Text, int.Parse(tbAnno.Text), new ObservableCollection<Actor>()));
        }

        private void btnAddActor_Click(object sender, RoutedEventArgs e)
        {
            listaPeliculas[listBox1.SelectedIndex].Actores.Add(new Actor(tbNombres.Text, string.Empty, int.Parse(tbAnnoNacimiento.Text)));
        }
    }
}