using RegistroDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDetalle.DAL
{    
        public class Contexto : DbContext
        {
            public DbSet<Asistencias> Asistencia { get; set; }
            public DbSet<Estudiantes> Estudiante { get; set; }
            public DbSet<Asignaturas> Asignatura { get; set; }

            public Contexto() : base("ConStr") { }
        }
    
}
