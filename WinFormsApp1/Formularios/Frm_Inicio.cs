using TPPAV1_Auditoria.Formularios.Odontologos;
using TPPAV1_Auditoria.Formularios.Prestaciones;
using TPPAV1_Auditoria.Formularios.Reintegros;

namespace WinFormsApp1
{
    public partial class Frm_Inicio : Form
    {
        
        public Frm_Inicio()
        {
            InitializeComponent();
        }

        private void aBMOdontologoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ABM_Odontologo ABM_Prestaciones = new Frm_ABM_Odontologo ();
            ABM_Prestaciones.ShowDialog();
        }

        private void aBMPrestacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ABM_Prestaciones ABM_Prestaciones = new Frm_ABM_Prestaciones();
            ABM_Prestaciones.ShowDialog();
        }

        private void aBMReintegroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ABM_Reintegro ABM_Reintegro = new Frm_ABM_Reintegro();
            ABM_Reintegro.ShowDialog();
        }
    }
}