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
    public partial class Frm_Afililiados_Baja : Form
    {
        public Frm_Afililiados_Baja()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            txt_nro_afiliado.Text = "";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            cmb_tipo_documento.SelectedIndex = -1;
            txt_nro_documento.Text = "";
        }

        private void Frm_Afililiados_Baja_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            cmb_tipo_documento.CargarCombo();
            cmb_tipo_documento.SelectedIndex = -1;
        }

        private void btn_gestionar_baja_Click(object sender, EventArgs e)
        {
            if (txt_nro_afiliado.Text == "" && txt_nombre.Text == "" && txt_apellido.Text == ""
                && txt_nro_documento.Text == "" && cmb_tipo_documento.SelectedIndex == -1)
            {
                MessageBox.Show("¡¡¡COMPLETAR AL MENOS UN CAMPO!!!");
            }
            else
            {
                MessageBox.Show("BAJA GESTIONADA CON ÉXITO");
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
