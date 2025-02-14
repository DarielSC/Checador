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
        public static string Nombre { get; private set; } // Nuevo campo para el nombre del usuario

        public static void IniciarSesion(string usuario, string rol, string nombre)
        {
            Usuario = usuario;
            Rol = rol;
            Nombre = nombre;
            DatoUsuario.RegistrarInicioSesion(usuario, rol);
        }

        public static void CerrarSesion()
        {
            DatoUsuario.RegistrarCierreSesion(Usuario, Rol);
            Usuario = null;
            Rol = null;
            Nombre = null;
        }

        public static bool EstaAutenticado => !string.IsNullOrEmpty(Usuario);
    }
}

