using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AccDatosB
{
    public class AccesoMySQL
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=1234;database=sakila;";
        MySqlConnection databaseConnection;
        MySqlCommand commandDatabase;
        MySqlDataReader reader;

        public AccesoMySQL(string query)
        {
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
        }

        public void ConectarABaseDatos()
        {
            databaseConnection.Open();
        }
        public ObservableCollection<string> LeerDatosConsultaDirecta()
        {
            ObservableCollection<string> listaNombres = new ObservableCollection<string>();
            reader = commandDatabase.ExecuteReader();
            // Hasta el momento todo bien, es decir datos obtenidos o no
            try
            { 
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // En nuestra base de datos de ejemplo, el array contiene: ID 0, FIRST_NAME 1,LAST_NAME 2, ADDRESS 3
                        // Hacer algo con cada fila obtenida
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                        listaNombres.Add(row[1]);
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron datos.");
                }
                return listaNombres;
            }
            catch (MySqlException ex) 
            {
                // Mostrar excepciones SQL
                MessageBox.Show(ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                // Mostrar cualquier excepción
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }
        public void CerrarConexion()
        {
            // Cerrar la conexión
            databaseConnection.Close();
        }

    }
}
