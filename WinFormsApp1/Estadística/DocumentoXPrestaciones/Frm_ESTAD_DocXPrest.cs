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

namespace TPPAV1_Auditoria.Estadística.DocumentoXPrestaciones
{
    public partial class Frm_ESTAD_DocXPrest : Form
    {
        public Frm_ESTAD_DocXPrest()
        {
            InitializeComponent();
        }

        private void Frm_ESTAD_DocXPrest_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            cb_codPrestacion.CargarCombo();
            cb_codPrestacion.SelectedIndex = -1;
            cb_codDocumento.CargarCombo();
            cb_codDocumento.SelectedIndex = -1;
        }
        private void LimpiarCampos()
        {
            cb_codPrestacion.SelectedIndex = -1;
            cb_codDocumento.SelectedIndex = -1;
            cb_Todos.Checked = false;
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
                    grid_Prestaciones.Rows[i].Cells[0].Value = tabla.Rows[i]["_Id"].ToString();
                    grid_Prestaciones.Rows[i].Cells[2].Value = tabla.Rows[i]["_documento"].ToString();
                    grid_Prestaciones.Rows[i].Cells[1].Value = tabla.Rows[i]["_codPrestacion"].ToString();
                }
            }
        }
        private void btn_consultar_Click(object sender, EventArgs e)
        {
            string codigoPrestacion = cb_codPrestacion.Text;
            string codigoDocumento = cb_codDocumento.Text;
            NE_documentoXprestaciones dXp = new NE_documentoXprestaciones();
            //FILTROS TODOS C/S EDAD
            grid_Prestaciones.Rows.Clear();
            DataTable tabla = new DataTable();

            string documento = cb_codDocumento.Text;
            if (cb_Todos.Checked == true)
            {
                CargarGrilla(dXp.Recuperar_Todos());
                return;
            }
            if (cb_codPrestacion.SelectedIndex != -1 && cb_codDocumento.SelectedIndex == -1)
            {
                CargarGrilla(dXp.Recuperar_Prestacion(codigoPrestacion));
                return;
            }
            if (cb_codDocumento.SelectedIndex != -1 && cb_codPrestacion.SelectedIndex == -1)
            {
                CargarGrilla(dXp.Recuperar_Documento(codigoDocumento));
                return;
            }
            if (txt_id.Text != "")
            {
                CargarGrilla(dXp.Recuperar_ID(txt_id.Text));
                return;
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            NE_documentoXprestaciones dXp = new NE_documentoXprestaciones();
            //FILTROS TODOS C/S EDAD
            string id = txt_id.Text;
            dXp.Pp_CodigoPrestacion = cb_codPrestacion.Text;
            dXp.Pp_CodigoDoc = cb_codDocumento.Text;
            dXp.Pp_Id = txt_id.Text;
            DataTable tabla = new DataTable();
            tabla = dXp.Recuperar_ID(txt_id.Text);

            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            if (tabla.Rows.Count == 0)
            {
                dXp.Insetar();
                MessageBox.Show("Documento por prestacion agregada");
                LimpiarCampos();
                return;
            }
            else
            {
                MessageBox.Show("documento ya existente");
                return;
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            NE_documentoXprestaciones dXp = new NE_documentoXprestaciones();
            //FILTROS TODOS C/S EDAD
            string id = txt_id.Text;
            dXp.Pp_CodigoPrestacion = cb_codPrestacion.Text;
            dXp.Pp_CodigoDoc = cb_codDocumento.Text;
            dXp.Pp_Id = txt_id.Text;

            DataTable tabla = new DataTable();
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            tabla = dXp.Recuperar_ID(txt_id.Text);

            if (tabla.Rows.Count > 0)
            {

                MessageBox.Show("Modificacion realizada");
                dXp.Pp_CodigoPrestacion = cb_codPrestacion.Text;
                dXp.Pp_CodigoDoc = cb_codDocumento.Text;                
                dXp.Modificar(txt_id.Text);
                LimpiarCampos();

            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            NE_documentoXprestaciones dXp = new NE_documentoXprestaciones();

            DataTable tabla = new DataTable();
            tabla = dXp.Recuperar_ID(txt_id.Text);

            if (tabla.Rows.Count > 0)
            {
                dXp.Eliminar(txt_id.Text.ToString());
                MessageBox.Show("Documento eliminado");
                LimpiarCampos();

            }
            else
            {
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("Documento no registrado, seleccione una Documento válido");
                    LimpiarCampos();
                }
            }
        }
    }
}
