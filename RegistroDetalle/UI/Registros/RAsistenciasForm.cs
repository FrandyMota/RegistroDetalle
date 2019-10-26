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
    public partial class RAsistenciasForm : Form
    {
        public List<EstudianteDetalle> Detalle { get; set; }
        public RAsistenciasForm()
        {
            InitializeComponent();
            this.Detalle = new List<EstudianteDetalle>();
        }

        private void REstudiantesFormbutton_Click(object sender, EventArgs e)
        {
            REstudiantes re = new REstudiantes();
            re.ShowDialog();

            EstudiantecomboBox.Items.Clear();

            RepositorioBase<Estudiantes> repositorioEstudiante = new RepositorioBase<Estudiantes>();

            foreach (var item in repositorioEstudiante.GetList(p => true))
            {
                EstudiantecomboBox.Items.Add(item.Nombre);
            }
        }

        private void Limpiar()
        {
            AsistenciaIdnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            AsignaturacomboBox.Text = string.Empty;
            EstudiantecomboBox.Text = string.Empty;
            PresentecheckBox.Checked = false;
            CantidadtextBox.Text = "0";
            MyerrorProvider.Clear();

            this.Detalle = new List<EstudianteDetalle>();
            CargarGrid();
        }

        private Asistencias LlenaClase()
        {
            Asistencias asistencia = new Asistencias();

            asistencia.AsistenciaId = (int)AsistenciaIdnumericUpDown.Value;
            asistencia.Fecha = FechadateTimePicker.Value;
            asistencia.Asignatura = AsignaturacomboBox.Text;
            asistencia.Cantidad = Convert.ToInt32(CantidadtextBox.Text);
            asistencia.Estudiantes = this.Detalle;

            return asistencia;
        }

        private void LlenaCampos(Asistencias asistencia)
        {
            AsistenciaIdnumericUpDown.Value = asistencia.AsistenciaId;
            FechadateTimePicker.Value = asistencia.Fecha;
            AsignaturacomboBox.Text = asistencia.Asignatura;
            CantidadtextBox.Text = Convert.ToString(asistencia.Cantidad);

            this.Detalle = asistencia.Estudiantes;
            CargarGrid();
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            AsistenciaRepos AP = new AsistenciaRepos();
            Asistencias asistencia = AP.Buscar((int)AsistenciaIdnumericUpDown.Value);
            return (asistencia != null);
        }

        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(Convert.ToString(FechadateTimePicker.Value)))
            {
                MyerrorProvider.SetError(FechadateTimePicker, "El campo Fecha no puede estar vacio");
                FechadateTimePicker.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(AsignaturacomboBox.Text))
            {
                MyerrorProvider.SetError(AsignaturacomboBox, "El campo Asignatura no puede estar vacio");
                AsignaturacomboBox.Focus();
                paso = false;
            }

            if (this.Detalle.Count == 0)
            {
                MyerrorProvider.SetError(AsistenciasdataGridView, "Debe agregar alguna asistencia a un estudiante");
                PresentecheckBox.Focus();
                paso = false;
            }

            return paso;
        }

        private bool ValidarCamposDetalle()
        {
            bool paso = true;

            if (EstudiantecomboBox.Text == string.Empty)
            {
                MyerrorProvider.SetError(EstudiantecomboBox, "Debe seleccionar un estudiante");
                EstudiantecomboBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void AgregarAsistenciabutton_Click(object sender, EventArgs e)
        {
            if (AsistenciasdataGridView.DataSource != null)
                this.Detalle = (List<EstudianteDetalle>)AsistenciasdataGridView.DataSource;

            if (!ValidarCamposDetalle())
                return;

            this.Detalle.Add(
                new EstudianteDetalle(
                    EstudianteId: 0,
                    Nombre: EstudiantecomboBox.Text,
                    Presente: PresentecheckBox.Checked,
                    AsistenciaId: (int)AsistenciaIdnumericUpDown.Value
                    )
                );

            CantidadtextBox.Text = Convert.ToString(Convert.ToInt32(CantidadtextBox.Text) + 1);

            CargarGrid();
            EstudiantecomboBox.Text = string.Empty;
            PresentecheckBox.Checked = false;
            EstudiantecomboBox.Focus();
        }

        private void CargarGrid()
        {
            AsistenciasdataGridView.DataSource = null;
            AsistenciasdataGridView.DataSource = this.Detalle;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Asistencias asistencia = new Asistencias();
            int.TryParse(Convert.ToString(AsistenciaIdnumericUpDown.Value), out id);
            AsistenciaRepos AR = new AsistenciaRepos();

            Limpiar();

            asistencia = AR.Buscar(id);

            if (asistencia != null)
                LlenaCampos(asistencia);
            else
                MessageBox.Show("¡Registro no encontrado!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            MyerrorProvider.Clear();
            int id;
            int.TryParse(Convert.ToString(AsistenciaIdnumericUpDown.Value), out id);
            AsistenciaRepos AR = new AsistenciaRepos();

            Limpiar();

            if (AR.Eliminar(id))
                MessageBox.Show("¡Registro eliminado exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyerrorProvider.SetError(AsistenciaIdnumericUpDown, "No se pudo eliminar el registro");
        }

            private void RAsistenciasForm_Load(object sender, EventArgs e)
            {
                EstudiantecomboBox.Items.Clear();
                AsignaturacomboBox.Items.Clear();

                RepositorioBase<Estudiantes> repositorioEstudiante = new RepositorioBase<Estudiantes>();
                RepositorioBase<Asignaturas> repositorioAsignatura = new RepositorioBase<Asignaturas>();

                foreach (var item in repositorioEstudiante.GetList(p => true))
                {
                    EstudiantecomboBox.Items.Add(item.Nombre);
                }

                foreach (var item in repositorioAsignatura.GetList(p => true))
                {
                    AsignaturacomboBox.Items.Add(item.Nombre);
                }

                CantidadtextBox.Text = "0";
            }

        }
    }

