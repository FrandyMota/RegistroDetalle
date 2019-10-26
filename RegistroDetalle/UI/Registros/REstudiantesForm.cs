using RegistroDetalle.BLL;
using RegistroDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDetalle.UI.Registros
{
    public partial class REstudiantes : Form
    {
        public REstudiantes()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            EstudianteIdnumericUpDown.Value = 0;
            NombreEstudiantetextBox.Text = string.Empty;
            MyerrorProvider.Clear();
        }

        private Estudiantes LlenaClase()
        {
            Estudiantes estudiante = new Estudiantes();

            estudiante.EstudianteId = (int)EstudianteIdnumericUpDown.Value;
            estudiante.Nombre = NombreEstudiantetextBox.Text;

            return estudiante;
        }

        private void LlenaCampos(Estudiantes estudiante)
        {
            EstudianteIdnumericUpDown.Value = estudiante.EstudianteId;
            NombreEstudiantetextBox.Text = estudiante.Nombre;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();
            Estudiantes estudiante = repositorio.Buscar((int)EstudianteIdnumericUpDown.Value);
            return (estudiante != null);
        }

        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(NombreEstudiantetextBox.Text))
            {
                MyerrorProvider.SetError(NombreEstudiantetextBox, "El campo Nombre no puede estar vacio");
                NombreEstudiantetextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Estudiantes estudiante;
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();

            if (!Validar())
                return;

            estudiante = LlenaClase();

            if (EstudianteIdnumericUpDown.Value == 0)
                paso = repositorio.Guardar(estudiante);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un registro que no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(estudiante);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("¡Guardado exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("¡No fue posible guardar!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            MyerrorProvider.Clear();
            int id;
            int.TryParse(Convert.ToString(EstudianteIdnumericUpDown.Value), out id);
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();

            Limpiar();

            if (repositorio.Eliminar(id))
                MessageBox.Show("¡Registro eliminado exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyerrorProvider.SetError(EstudianteIdnumericUpDown, "No se pudo eliminar el registro");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Estudiantes estudiante = new Estudiantes();
            int.TryParse(Convert.ToString(EstudianteIdnumericUpDown.Value), out id);
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();

            Limpiar();

            estudiante = repositorio.Buscar(id);

            if (estudiante != null)
                LlenaCampos(estudiante);
            else
                MessageBox.Show("¡Registro no encontrado!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
