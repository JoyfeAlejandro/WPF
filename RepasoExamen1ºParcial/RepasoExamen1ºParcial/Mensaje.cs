using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamen1ºParcial
{
    public class Mensaje // La clase tiene que ser PUBLICA aaaaa
    {
        public Mensaje() { }

        public Mensaje(string texto)
        {
            Texto = texto;
        }

        public string Texto { get; set; }
    }
}
