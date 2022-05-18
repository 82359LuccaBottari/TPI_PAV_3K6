using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPPAV1_Auditoria.Negocios;

namespace TPPAV1_Auditoria.Formularios.Odontologos
{
    public partial class Frm_Odontologo_Baja : Form
    {
        public Frm_Odontologo_Baja()
        {
            InitializeComponent();
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
             NE_odontologo odontologo = new NE_odontologo();
                string codigo = txt_Matricula.Text.Trim();
                DataTable tabla = new DataTable();
                tabla = odontologo.Recuperar_Matricula(codigo);
                if (tabla.Rows.Count == 1)
                {
                    if (txt_Matricula.Text.Trim() != "")
                    {
                        odontologo.Eliminar(codigo);
                        MessageBox.Show("Eliminación exitosa");
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Inserte Codigo de prestacion");
                        txt_Matricula.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Inserte codigo");
                    txt_Matricula.Focus();
                }

        
        }
        private void LimpiarCampos()
        {
            txt_Matricula.Text = "";
        }
    }
}
