using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDetalle.Entidades
{
    public class Asistencias
    {
        [Key]
        public int AsistenciaId { get; set; }
        public string Asignatura { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public int AsignaturaId { get; set; }
        public virtual List<EstudianteDetalle> Estudiantes { get; set; }

        public Asistencias()
        {
            AsistenciaId = 0;
            Asignatura = string.Empty;
            Fecha = DateTime.Now;
            Cantidad = 0;
            AsignaturaId = 0;
            Estudiantes = new List<EstudianteDetalle>();
        }
    }
}
