using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDetalle.Entidades
{
    public class EstudianteDetalle
    {
        [Key]
        public int EstudianteDetalleId { get; set; }
        public string Nombre { get; set; }
        public bool Presente { get; set; }
        public int AsistenciaId { get; set; }

        public EstudianteDetalle()
        {
            EstudianteDetalleId = 0;
            Nombre = string.Empty;
            Presente = false;
            AsistenciaId = 0;
        }

        public EstudianteDetalle(int EstudianteId, string Nombre, bool Presente, int AsistenciaId)
        {
            this.EstudianteDetalleId = EstudianteId;
            this.Nombre = Nombre;
            this.Presente = Presente;
            this.AsistenciaId = AsistenciaId;
        }
    }
}
