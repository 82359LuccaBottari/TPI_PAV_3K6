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

namespace TPPAV1_Auditoria.Formularios.Atenciones
{
    public partial class Frm_ABM_Atenciones : Form
    {
        public Frm_ABM_Atenciones()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Atenciones_Load(object sender, EventArgs e)
        {

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            grid_Atenciones.Rows.Clear();
            NE_atenciones Atenciones = new NE_atenciones();
            DataTable tabla = new DataTable();
            if (rb_nroAfiliado.Checked == true)
            {
                string nroAfiliado = mkt_numeroAfiliado.Text;
                tabla = Atenciones.Recuperar_Patron_NumeroAfiliado(nroAfiliado);
                CargarGrilla(tabla);
                return;
            }
            if (rb_codigoCategoria.Checked == true) 
            {
                string codCategoria = mkt_codigoCategoria.Text;
                tabla = Atenciones.Recuperar_Patron_CodigoCategoria(codCategoria);
                CargarGrilla(tabla);
                return;
            }
            if (rb_codigoPrestacion.Checked == true)
            {
                string codigoPrestacion = mkt_CodigoPrestacion.Text;
                tabla = Atenciones.Recuperar_Patron_CodigoPrestacion(codigoPrestacion);
                CargarGrilla(tabla);
                return;
            }
            if (rb_fechaAtención.Checked == true)
            {
                string fechaAtencion = mkt_fechaAtencion.Text;
                tabla = Atenciones.Recuperar_Patron_FechaAtencion(fechaAtencion);
                CargarGrilla(tabla);
                return;
            }
            if (rb_nroElemento.Checked == true)
            {
                string nroElemenento = mkt_numeroElemento.Text;
                tabla = Atenciones.Recuperar_Patron_NumeroAfiliado(nroElemenento);
                CargarGrilla(tabla);
                return;
            }
            if (rb_matricula.Checked == true)
            {
                string matricula = mkt_matricula.Text;
                tabla = Atenciones.Recuperar_Patron_NumeroAfiliado(matricula);
                CargarGrilla(tabla);
                return;
            }
            if (rb_numeroExpediente.Checked == true)
            {
                string nroExped = mkt_numeroExpediente.Text;
                tabla = Atenciones.Recuperar_Patron_NumeroAfiliado(nroExped);
                CargarGrilla(tabla);
                return;
            }
            if (rb_codigoDocumento.Checked == true)
            {
                string codDoc = mkt_codigoDocumento.Text;
                tabla = Atenciones.Recuperar_Patron_NumeroAfiliado(codDoc);
                CargarGrilla(tabla);
                return;
            }
            tabla = Atenciones.Recuperar_Todos();
            CargarGrilla(tabla);
            return;
        }
        private void CargarGrilla(DataTable tabla)
        {
            if (tabla.Rows.Count == 0)
            {
                grid_Atenciones.Rows.Clear();
            }
            else
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    grid_Atenciones.Rows.Add(tabla.Rows[i]);
                    grid_Atenciones.Rows[i].Cells[0].Value = tabla.Rows[i]["_NroAfiliado"].ToString();
                    grid_Atenciones.Rows[i].Cells[1].Value = tabla.Rows[i]["_CodCateg"].ToString();
                    grid_Atenciones.Rows[i].Cells[2].Value = tabla.Rows[i]["_CodPrestac"].ToString();
                    grid_Atenciones.Rows[i].Cells[3].Value = tabla.Rows[i]["_Fecha_Atenc"].ToString();
                    grid_Atenciones.Rows[i].Cells[4].Value = tabla.Rows[i]["_NroElem"].ToString();
                    grid_Atenciones.Rows[i].Cells[5].Value = tabla.Rows[i]["_CodTipo"].ToString();
                    grid_Atenciones.Rows[i].Cells[6].Value = tabla.Rows[i]["_Matricula"].ToString();
                    grid_Atenciones.Rows[i].Cells[7].Value = tabla.Rows[i]["_Nro_exped"].ToString();

                }
            }
        }
    }
}
