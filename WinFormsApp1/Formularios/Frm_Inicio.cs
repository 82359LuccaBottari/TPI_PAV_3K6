using TPPAV1_Auditoria.Formularios.Odontologos;
using TPPAV1_Auditoria.Formularios.Prestaciones;
using TPPAV1_Auditoria.Formularios.Reintegros;
using TPPAV1_Auditoria.Formularios.Atenciones;
using TPPAV1_Auditoria.Formularios.Afiliados;
using TPPAV1_Auditoria.Formularios.Expedientes;
namespace WinFormsApp1
{
    public partial class Frm_Inicio : Form
    {
        
        public Frm_Inicio()
        {
            InitializeComponent();
        }

        private void aBMAfiliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ABM_Afiliados ABMAfiliados = new Frm_ABM_Afiliados();
            ABMAfiliados.ShowDialog();
        }

        private void aBMOdontologoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ABM_Odontologo ABMOdontologo = new Frm_ABM_Odontologo();
            ABMOdontologo.ShowDialog();
        }

        private void estadisticasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void atencionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_ABM_Atenciones ABMAtenciones = new Frm_ABM_Atenciones();
            ABMAtenciones.ShowDialog();
        }

        private void revisacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void prestacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_ABM_Prestaciones ABM_Prestaciones = new Frm_ABM_Prestaciones();
            ABM_Prestaciones.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void elementosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void documentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void expedientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tipoDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void funcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void expedientePorEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ABM_Expedientes ABMExpedientes = new Frm_ABM_Expedientes();
            ABMExpedientes.ShowDialog();
        }

        private void prestacionesPorElementosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void elementosPorPrestacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void documentosPorPrestacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void odontologoPorTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void documentosPorExpedienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}