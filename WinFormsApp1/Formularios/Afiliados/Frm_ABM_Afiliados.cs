using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPPAV1_Auditoria.Clases;
using WinFormsApp1.Clases;
using TPPAV1_Auditoria.Negocios;


namespace TPPAV1_Auditoria.Formularios.Afiliados
{
    public partial class Frm_ABM_Afiliados : Form
    {
        public Frm_ABM_Afiliados()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Afiliados_Load(object sender, EventArgs e)
        {
            cmb_categorias.CargarCombo();
            cmb_categorias.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmb_categorias.SelectedIndex = -1;
        }

        private void btn_consulta_afiliados_Click(object sender, EventArgs e)
        {
            NE_afiliados afiliado = new NE_afiliados();
            if (chk_todos.Checked == true)
            {
                DataTable tabla = new DataTable();
                tabla = afiliado.RecuperarTodos();
                CargarGrilla(tabla);
                return;
            }
            if (cmb_categorias.SelectedIndex != -1)
            {
                CargarGrilla(afiliado.Recuperar_x_Categorias(cmb_categorias.SelectedValue.ToString()));
                return;
            }
            if (txt_nro_afiliado.Text != "")
            {
                CargarGrilla(afiliado.Recuperar_x_NroAfiliado(txt_nro_afiliado.Text));
            }
        }
        private void CargarGrilla(DataTable tabla)
        {
            grid_afiliados.Rows.Clear();
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    grid_afiliados.Rows.Add();
                    grid_afiliados.Rows[i].Cells[0].Value = tabla.Rows[i]["_NroAfiliado"].ToString();
                    grid_afiliados.Rows[i].Cells[1].Value = tabla.Rows[i]["n_CodCategoria"].ToString();
                    grid_afiliados.Rows[i].Cells[2].Value = tabla.Rows[i]["_Apellido"].ToString();
                    grid_afiliados.Rows[i].Cells[3].Value = tabla.Rows[i]["_Nombre"].ToString();
                }
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Frm_Afililiados_Alta Alta_Afiliados = new Frm_Afililiados_Alta();
            Alta_Afiliados.Show();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Frm_Afililiados_Baja Baja_Afiliados = new Frm_Afililiados_Baja();
            Baja_Afiliados.Show();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Frm_Afililiados_Modificacion Modificacion_Afiliados = new Frm_Afililiados_Modificacion();
            Modificacion_Afiliados.Show();
        }
    }
}
