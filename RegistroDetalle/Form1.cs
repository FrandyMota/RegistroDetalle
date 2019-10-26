using RegistroDetalle.UI.Consultas;
using RegistroDetalle.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDetalle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registroAsistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RAsistenciasForm ra = new RAsistenciasForm();
            ra.Show();
        }

        private void registroAsignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RAsignaturasForm ras = new RAsignaturasForm();
            ras.Show();
        }

        private void registroEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REstudiantes re = new REstudiantes();
            re.Show();
        }

        private void consultaAsistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CAsistenciasForm ca = new CAsistenciasForm();
            ca.Show();
        }
    }
}
