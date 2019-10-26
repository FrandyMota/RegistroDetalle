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
    public partial class RAsignaturasForm : Form
    {
        public RAsignaturasForm()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            AsignaturaIdnumericUpDown.Value = 0;
            NombreAsignaturatextBox.Text = string.Empty;
            MyerrorProvider.Clear();
        }

        private Asignaturas LlenaClase()
        {
            Asignaturas asignatura = new Asignaturas();

            asignatura.AsignaturaId = (int)AsignaturaIdnumericUpDown.Value;
            asignatura.Nombre = NombreAsignaturatextBox.Text;

            return asignatura;
        }

        private void LlenaCampos(Asignaturas asignatura)
        {
            AsignaturaIdnumericUpDown.Value = asignatura.AsignaturaId;
            NombreAsignaturatextBox.Text = asignatura.Nombre;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            Asignaturas asignatura = repositorio.Buscar((int)AsignaturaIdnumericUpDown.Value);
            return (asignatura != null);
        }

        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(NombreAsignaturatextBox.Text))
            {
                MyerrorProvider.SetError(NombreAsignaturatextBox, "El campo Nombre no puede estar vacio");
                NombreAsignaturatextBox.Focus();
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
            Asignaturas asignatura;
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();

            if (!Validar())
                return;

            asignatura = LlenaClase();

            if (AsignaturaIdnumericUpDown.Value == 0)
                paso = repositorio.Guardar(asignatura);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un registro que no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(asignatura);
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
            int.TryParse(Convert.ToString(AsignaturaIdnumericUpDown.Value), out id);
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();

            Limpiar();

            if (repositorio.Eliminar(id))
                MessageBox.Show("¡Registro eliminado exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyerrorProvider.SetError(AsignaturaIdnumericUpDown, "No se pudo eliminar el registro");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Asignaturas asignatura = new Asignaturas();
            int.TryParse(Convert.ToString(AsignaturaIdnumericUpDown.Value), out id);
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();

            Limpiar();

            asignatura = repositorio.Buscar(id);

            if (asignatura != null)
                LlenaCampos(asignatura);
            else
                MessageBox.Show("¡Registro no encontrado!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
