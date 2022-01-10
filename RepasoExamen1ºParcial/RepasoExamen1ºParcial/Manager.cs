using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; // La cosa del ObservableCollection
using System.ComponentModel; // La cosa del PropertyChanged nº1
using System.Runtime.CompilerServices; // La cosa del PropertyChanged nº2
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamen1ºParcial
{
    public class Manager : INotifyPropertyChanged // Cosa para cambiar vista nº1  (Además la clase es PUBLICA)
    {
        public event PropertyChangedEventHandler PropertyChanged; // Cosa para cambiar vista nº2

        public ObservableCollection<Mensaje> _mensajes = new ObservableCollection<Mensaje>();

        public Manager() { }

        public ObservableCollection<Mensaje> Mensajes
        {
            get
            {
                return _mensajes;
            }
            set
            {
                _mensajes = value;

                OnPropertyChanged(); // Cosa para cambiar vista, lo pones donde se tenga que cambiar. 
                                     // Aquí en concreto no sirve pero lo pongo para tenerlo por ahí
                                     // Normalmente va en el setter de la propoedad con los datos que quieres cambiar
            }
        }

        public void AñadirMensaje(string texto)
        {
            Mensajes.Add(new Mensaje(texto));
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null) // Cosa para cambiar vista nº3
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
