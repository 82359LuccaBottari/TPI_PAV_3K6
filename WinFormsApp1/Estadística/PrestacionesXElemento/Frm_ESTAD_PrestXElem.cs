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
using WinFormsApp1.Clases;

namespace TPPAV1_Auditoria.Estadística.PrestacionesXElemento
{
    public partial class Frm_ESTAD_PrestXElem : Form
    {
        public Frm_ESTAD_PrestXElem()
        {
            InitializeComponent();
        }

        

        private void Frm_ESTAD_PrestXElem_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            cb_prestacion.CargarCombo();            
            cb_prestacion.SelectedIndex = -1;
            cb_elemento.CargarCombo();
            cb_elemento.SelectedIndex = -1;
        }
        private void CargarGrilla(DataTable tabla)
        {
            if (tabla.Rows.Count == 0)
            {
                grid_Prestaciones.Rows.Clear();
            }
            else
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    grid_Prestaciones.Rows.Add(tabla.Rows[i]);
                    grid_Prestaciones.Rows[i].Cells[0].Value = tabla.Rows[i]["Id"].ToString();
                    grid_Prestaciones.Rows[i].Cells[1].Value = tabla.Rows[i]["CodPrestacion"].ToString();
                    grid_Prestaciones.Rows[i].Cells[2].Value = tabla.Rows[i]["NroElemento"].ToString();
                    grid_Prestaciones.Rows[i].Cells[3].Value = tabla.Rows[i]["DiasGarantia"].ToString();
                }
            }
        }

        private void brn_consultar_Click(object sender, EventArgs e)
        {
            string codigoPrestacion = cb_prestacion.Text;
            NE_prestacionesXelemento pXe = new NE_prestacionesXelemento();
            //FILTROS TODOS C/S EDAD
            grid_Prestaciones.Rows.Clear();
            DataTable tabla = new DataTable();
            string prestacion = cb_prestacion.Text;
            string elemento = cb_elemento.Text;
            if (cb_Todos.Checked == true)
            {
                CargarGrilla(pXe.Recuperar_Todos());
                return;
            }
            if (cb_prestacion.SelectedIndex != -1 && cb_elemento.SelectedIndex == -1) 
            {
                CargarGrilla(pXe.Recuperar_Prestacion(prestacion));
                return;
            }
            if (cb_elemento.SelectedIndex != -1 && cb_prestacion.SelectedIndex == -1) 
            {
                CargarGrilla(pXe.Recuperar_Elemento(elemento));
                return;
            }
            if (txt_id.Text != "") 
            {
                CargarGrilla(pXe.Recuperar_ID(txt_id.Text));
                return;
            }

        }

        
        private void LimpiarCampos() 
        {
            cb_elemento.SelectedIndex = -1;
            cb_prestacion.SelectedIndex = -1;
            cb_diasgarantia.SelectedIndex = -1;
            txt_id.Text = "";
            cb_Todos.Checked = false;
        }

        private void brn_agregar_Click(object sender, EventArgs e)
        {

            NE_prestacionesXelemento pXe = new NE_prestacionesXelemento();
            string id = txt_id.Text;
            pXe.Pp_CodigoPrestacion = cb_prestacion.Text;
            pXe.Pp_NroElemento= cb_elemento.Text;
            pXe.Pp_DiasGarantias = cb_diasgarantia.Text;
            DataTable tabla = new DataTable();
            tabla = pXe.Recuperar_ID(txt_id.Text);

            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            if (tabla.Rows.Count == 0)
            {
                pXe.Insetar();
                MessageBox.Show("Prestación por elemento agregada");
                LimpiarCampos();
                return;
            }
            else
            {
                MessageBox.Show("Prestacion ya existente");                
                return;
            }
            



            
        }
        private void brn_eliminar_Click(object sender, EventArgs e)
        {
            NE_prestacionesXelemento pXe = new NE_prestacionesXelemento();
            DataTable tabla = new DataTable();
            tabla = pXe.Recuperar_ID(txt_id.Text);

            if (tabla.Rows.Count > 0)
            {
                pXe.Eliminar(txt_id.Text.ToString());
                MessageBox.Show("Prestación eliminada");
                LimpiarCampos();

            }
            else
            {
                if (tabla.Rows.Count == 0) 
                {
                    MessageBox.Show("Prestacion no registrada, seleccione una prestacion válida");
                    LimpiarCampos();
                }
            }

            
            
        }
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            NE_prestacionesXelemento pXe = new NE_prestacionesXelemento();

            pXe.Pp_CodigoPrestacion = cb_prestacion.Text;
            pXe.Pp_NroElemento = cb_elemento.Text;
            pXe.Pp_DiasGarantias = cb_diasgarantia.Text;
                      
            DataTable tabla = new DataTable();
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            tabla = pXe.Recuperar_ID(txt_id.Text);

            if (tabla.Rows.Count > 0)
            {
                
                MessageBox.Show("Modificacion realizada");
                pXe.Pp_NroElemento = cb_elemento.Text;
                pXe.Pp_DiasGarantias = cb_diasgarantia.Text;
                pXe.Pp_CodigoPrestacion = cb_prestacion.Text;
                pXe.Modificar(txt_id.Text);
                LimpiarCampos();

            }
            
        }
        

        private void cb_prestacion_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
