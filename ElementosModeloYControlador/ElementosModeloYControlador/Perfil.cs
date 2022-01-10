using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ElementosModeloYControlador
{

    public class Perfil : INotifyPropertyChanged
    {
        // Declare the event
        public event PropertyChangedEventHandler PropertyChanged;
        public enum Dificultad { Fácil, Medio, Difícil };
        //CAMPOS
        private string _nombre;
        private string _apellido_1;
        private string _apellido_2;
        private string _nick;
        private DateTime _fecha_Nacimiento;
        private int _resolucionAltura;
        private int _resolucionAnchura;
        private int _volumenMusica;
        private Dificultad _dificultadPrograma;

        //PROPIEDADES
        public string Nombre
        {
            get { return _nombre; }
            set { 
                _nombre = value;
                OnPropertyChanged();
            }
        }
        public string Apellido1
        {
            get { return _apellido_1; }
            set { _apellido_1 = value; }
        }
        public string Nick
        {
            get { return _nick; }
        }
        public int ResolucionAltura
        {
            get { return _resolucionAltura; }
            set { _resolucionAltura = value;
                OnPropertyChanged();
            }
        }
        public int ResolucionAnchura
        {
            get { return _resolucionAnchura; }
            set { _resolucionAnchura = value;
                OnPropertyChanged();
            }
        }
        public int VolumenMusica
        {
            get { return _volumenMusica; }
            set { _volumenMusica = value; }
        }
        public Dificultad DificultadPrograma
        {
            get { return _dificultadPrograma; }
            set { _dificultadPrograma = value; }
        }

        //CONSTRUCTORES
        public Perfil()
        {
            _nombre = "Pepe";
            _apellido_1 = "Brías";
            _apellido_2 = "";
            _nick = "Player";
            _dificultadPrograma = Dificultad.Medio;
            _resolucionAltura   = 600;
            _resolucionAnchura  = 600;
            _volumenMusica      = 0;
            _fecha_Nacimiento = DateTime.Today;
        }

        //METODOS
        public bool RegistrarFecha(DateTime nuevaFechaNac)
        {
            //Comprobar si es mayor de edad
            if(DateTime.Now.Year - nuevaFechaNac.Year >= 18)
            {
                _fecha_Nacimiento = nuevaFechaNac;
                return true;
            }
            return false;
        }
        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
