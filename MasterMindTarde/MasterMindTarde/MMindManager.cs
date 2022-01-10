using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;

namespace MasterMindTarde
{
    public class MMindManager : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        //Campos privados
        private int[] _secuencia_objetivo = new int[5];
        ObservableCollection<Intento> _historico = new ObservableCollection<Intento>();

        //Propiedades
        public ObservableCollection<Intento> Historico
        {
            get
            {
                return _historico;
            }
            set
            {
                _historico = value;
            }
        }
        //Constructor(es)
        public MMindManager()
        {
            //Generar una nueva secuencia CPU
            Random r = new Random(DateTime.Now.Millisecond);
            _secuencia_objetivo[0] = r.Next(0, 9);
            _secuencia_objetivo[1] = r.Next(0, 9);
            _secuencia_objetivo[2] = r.Next(0, 9);
            _secuencia_objetivo[3] = r.Next(0, 9);
            _secuencia_objetivo[4] = r.Next(0, 9);
        }

        //Metodos
        public string Intentar(int[] secuencia_jugador)
        {
            bool acierto_completo = true;
            int aciertos_exactos = 0;
            int aciertos_parciales = 0;
            Intento nuevoIntento = new Intento(secuencia_jugador, "");
            _historico.Add(nuevoIntento);

            //ALGORITMO DE COMPROBACION
            //SI COINCIDE secuencia_jugador con _secuencia_objetivo
            for(int i=0; i<5; i++)
            {
                if(secuencia_jugador[i] != _secuencia_objetivo[i])
                    acierto_completo = false;
                else
                    aciertos_exactos++;
            }
            if (acierto_completo)
            {
                nuevoIntento.Resultado = "Enhorabuena, has acertado";
            }
            else
            {
                //CONTAR CUANTOS ACIERTOS NO EXACTOS
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (_secuencia_objetivo[i] == secuencia_jugador[j] && i != j)
                        {
                            aciertos_parciales++;
                        }
                    }
                }
                nuevoIntento.Resultado = "Has tenido " + aciertos_exactos +
                                         " aciertos exactos y " + aciertos_parciales +
                                         " aciertos parciales";
            }
            return nuevoIntento.Resultado;
        }



        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}