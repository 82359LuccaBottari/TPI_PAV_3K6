using TPPAV1_Auditoria.Formularios.Reintegros;

namespace WinFormsApp1
{
    public partial class Frm_Inicio : Form
    {
        public Frm_Inicio()

         
        {
            InitializeComponent();
        }

        private void Frm_Inicio_Load(object sender, EventArgs e)
        {

        }

        private void aBMReintegroToolStripMenuItem_Click(object sender, EventArgs e)
        
        {
            Frm_ABM_Reintegro frmreintegro = new Frm_ABM_Reintegro();


        }
    }
}