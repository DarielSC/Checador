using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chk.Modelos
{
    public class ComparativaAsistencia
    {
        public string MatriculaRepetida { get; set; }
        public string MatriculaNoRepetida { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cargo { get; set; }  // Grado o Cargo
        public string Departamento { get; set; }
        public DateTime? FechaHoraAsistencia { get; set; }
    }
}
