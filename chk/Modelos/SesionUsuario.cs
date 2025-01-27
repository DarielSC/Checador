using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using chk.Servicios;
using MySql.Data.MySqlClient;

namespace chk.Modelos
{
    public static class SesionUsuario
    {
        public static string Usuario { get; private set; }
        public static string Rol { get; private set; }

        public static void IniciarSesion(string usuario, string rol)
        {
            Usuario = usuario;
            Rol = rol;
            RegistrarInicioSesion(usuario, rol); // Registrar inicio de sesión
        }

        public static void CerrarSesion()
        {
            RegistrarCierreSesion(Usuario, Rol); // Registrar cierre de sesión
            Usuario = null;
            Rol = null;
        }

        public static bool EstaAutenticado => !string.IsNullOrEmpty(Usuario);

        public static void RegistrarInicioSesion(string usuario, string rol)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    using (var conn = connection.CreateCommand())
                    {
                        conn.CommandType = CommandType.StoredProcedure;
                        conn.CommandText = "RegistrarInicioSesion";

                        conn.Parameters.AddWithValue("pUsuario", usuario);
                        conn.Parameters.AddWithValue("pRol", rol); // Enviar el rol
                        conn.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al registrar el inicio de sesión: " + ex.Message);
            }
        }

        private static void RegistrarCierreSesion(string usuario, string rol)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    using(var conn = connection.CreateCommand())
                    {
                        conn.CommandType = CommandType.StoredProcedure;
                        conn.CommandText = "RegistrarCierreSesion";

                        conn.Parameters.AddWithValue("pUsuario", usuario);
                        conn.Parameters.AddWithValue("pRol", rol); // Enviar el rol
                        conn.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al registrar el cierre de sesión: " + ex.Message);
            }
        }
    }
}
