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

namespace RegistroDetalle.UI.Consultas
{
    public partial class CAsistenciasForm : Form
    {
        public CAsistenciasForm()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            List<Asistencias> listado = new List<Asistencias>();
            RepositorioBase<Asistencias> repositorio = new RepositorioBase<Asistencias>();

            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0://Todos
                        listado = repositorio.GetList(p => true);
                        break;

                    case 1://Id
                        int id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = repositorio.GetList(p => p.AsistenciaId == id);
                        break;

                    case 2://Asignatura
                        listado = repositorio.GetList(p => p.Asignatura.Contains(CriteriotextBox.Text));
                        break;
                }

                listado = repositorio.GetList(c => c.Fecha.Date >= DesdedateTimePicker.Value.Date && c.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = repositorio.GetList(p => true);
            }

            ConsultadataGridView.DataSource = null;
            ConsultadataGridView.DataSource = listado;
        }
    }
}
