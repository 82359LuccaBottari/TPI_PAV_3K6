using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Clases;
using TPPAV1_Auditoria.Clases;
using TPPAV1_Auditoria.Negocios;

namespace TPPAV1_Auditoria.Formularios.Odontologos
{
    public partial class Frm_odontologo_Modificar : Form
    {
        public Frm_odontologo_Modificar()
        {
            InitializeComponent();
        }

        private void btn_Gestionar_Click(object sender, EventArgs e)
        {
           
        }
        private void LimpiarCampos()
        {
            txt_Apellido.Text = "";
            txt_Nombre.Text = "";
            txt_Matricula.Text = "";

        }
        private void GenerarDatos(string codigo)
        {
            NE_odontologo odontologo = new NE_odontologo();
            DataTable tabla = new DataTable();
            tabla = odontologo.Recuperar_Matricula(codigo);
            string Nombre = tabla.Rows[0]["_Nombre"].ToString();
            string Apellido = tabla.Rows[0]["_Apellido"].ToString();
            txt_Nombre.Text = Nombre;
            txt_Apellido.Text = Apellido;
            return;

        }

        private void btn_gestionar_modificacion_Click(object sender, EventArgs e)
        {
            NE_odontologo odontologo = new NE_odontologo();
            string codigo = txt_Matricula.Text;
            DataTable tabla = new DataTable();
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();

            if (codigo != "")
            {
                tabla = odontologo.Recuperar_Matricula(codigo);
                if (txt_Nombre.Text != "" && txt_Apellido.Text != "")
                {
                    odontologo.Pp_Nombre = txt_Nombre.Text;
                    odontologo.Pp_Apellido = txt_Apellido.Text;
                    odontologo.Modificar(codigo);
                    MessageBox.Show("Modificación exitosa");
                    LimpiarCampos();

                }
                else
                {
                    GenerarDatos(codigo);
                    MessageBox.Show("Ingrese datos");
                }
            }

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


