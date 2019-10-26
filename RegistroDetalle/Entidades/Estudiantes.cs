using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDetalle.Entidades
{
    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }
        public string Nombre { get; set; }
        public bool Presente { get; set; }

        public Estudiantes()
        {
            EstudianteId = 0;
            Nombre = string.Empty;
            Presente = false;
        }
    }
}
