using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPPAV1_Auditoria.Formularios.Afiliados
{
    public partial class Frm_Afililiados_Modificacion : Form
    {
        public Frm_Afililiados_Modificacion()
        {
            InitializeComponent();
        }
        private void LimpiarCampos()
        {
            txt_nro_afiliado.Text = "";
            cmb_categorias.SelectedIndex = -1;
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            cmb_tipo_documento.SelectedIndex = -1;
            txt_nro_documento.Text = "";
            txt_fecha_nacimiento.Text = "";
        }
        private void Frm_Afililiados_Modificacion_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            cmb_categorias.CargarCombo();
            cmb_categorias.SelectedIndex = -1;
            cmb_tipo_documento.CargarCombo();
            cmb_tipo_documento.SelectedIndex = -1;
        }
        private void btn_gestionar_modificacion_Click(object sender, EventArgs e)
        {
            if (txt_nro_afiliado.Text != "" && txt_nombre.Text != "" && txt_apellido.Text != ""
                && txt_nro_documento.Text != "" && txt_fecha_nacimiento.Text != ""
                && cmb_categorias.SelectedIndex != -1 && cmb_tipo_documento.SelectedIndex != -1)
            {
                MessageBox.Show("MODIFICACIÓN GESTIONADA CON ÉXITO");
            }
                
        }

        private void cmb_tipo_documento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_tipo_documento.SelectedIndex != -1)
            {
                txt_nro_documento.Enabled = true;
            }
            else
            {
                txt_nro_documento.Enabled = false;
            }
        }

        
    }
}
