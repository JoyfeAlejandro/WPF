using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_Interfaces_1
{
    class Coche
    {
        //Campos
        string _modelo;
        decimal _kilometros;
        string _matricula;
        string _color;
        int _n_puertas;
        
        //Propiedades
        public string Modelo
        {
            get
            {
                return _modelo;
            }

            set
            {
                _modelo = value;
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
            }
        }

        public decimal Kilometros
        {
            get
            {
                return _kilometros;
            }

            set
            {
                _kilometros = value;
            }
        }

        //Construcctores
        public Coche()
        {

        }

        //Metodos
        public void Cambiar_matricula()
        {

        }

        public void Actualizar_kilometros(decimal nuevoKilometraje)
        {
            _kilometros = nuevoKilometraje;
        }
    }
}
