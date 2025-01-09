using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace chk.Servicios
{
    // Clase para manejar la conexión a la base de datos MySQL
    public class DatabaseHelper
    {
        private static string GetConnectionString()
        {
            // Leer la variable de entorno
            string connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("La cadena de conexión no está configurada como variable de entorno.");
            }

            return connectionString;
        }

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(GetConnectionString());
        }
    }
}
