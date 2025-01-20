 using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows;

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

        // Realiza el respaldo de la base de datos usando una variable de entorno para el comando
        public static bool RespaldarBaseDeDatos(string backupFile)
        {
            try
            {
                // Obtener el comando desde la variable de entorno
                string backupCommand = Environment.GetEnvironmentVariable("MYSQL_BACKUP_COMMAND");

                if (string.IsNullOrEmpty(backupCommand))
                {
                    throw new InvalidOperationException("El comando de respaldo no está configurado como variable de entorno.");
                }

                // Reemplazar la ruta del archivo de respaldo en el comando
                string command = backupCommand.Replace("{backupFile}", backupFile);

                // Ejecutar el comando
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(psi))
                {
                    using (StreamWriter sw = process.StandardInput)
                    {
                        if (sw.BaseStream.CanWrite)
                        {
                            sw.WriteLine(command);
                        }
                    }

                    process.WaitForExit();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar el respaldo: " + ex.Message, "Error");
                return false;
            }
        }

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(GetConnectionString());
        }
    }
}
