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
            DatoUsuario.RegistrarInicioSesion(usuario, rol); // Llamar al nuevo método
        }

        public static void CerrarSesion()
        {
            DatoUsuario.RegistrarCierreSesion(Usuario, Rol); // Llamar al nuevo método
            Usuario = null;
            Rol = null;
        }
        public static bool EstaAutenticado => !string.IsNullOrEmpty(Usuario);
    }
}
