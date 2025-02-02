using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chk.Modelos
{
    public class Usuario
    {
        public Usuario() { }

        //Atributos de la clase Usuario
        public int Id { get; set; }
        public string Matricula { get; set; } = string.Empty;
        public string Contrasena { get; set; } = string.Empty;
        public string Rol { get; set; } = string.Empty;
        public DateTime? FechaRegistro { get; set; }

    }
}
