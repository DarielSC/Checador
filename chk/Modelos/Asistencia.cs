using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chk.Modelos
{
    public class Asistencia
    {
        public Asistencia() { }
        //Atributos de la clase Asistencia
        public int IDRegistro { get; set; }
        public string Matricula { get; set; } = string.Empty;
        public string Departamento { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Grado { get; set; } = string.Empty;
        public byte[] Huella { get; set; } = Array.Empty<byte>();
        public DateTime? FechaHoraAsistencia { get; set; }

    }
}

