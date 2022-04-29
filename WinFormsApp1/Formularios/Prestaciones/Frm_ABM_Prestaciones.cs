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

namespace TPPAV1_Auditoria.Formularios.Prestaciones
{
    public partial class Frm_ABM_Prestaciones : Form
    {
        
        public Frm_ABM_Prestaciones()
        {
            InitializeComponent();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            //VALIDAR CAMPOS VACIOS
            if (rb_codigoPrestacion.Checked == false && cb_Edad.Checked == false && rb_todos.Checked == false) 
            {
                MessageBox.Show("Seleccione los filtros");

            }
            //FILTROS TODOS C/S EDAD
            grid_Prestaciones.Rows.Clear();
            if (rb_todos.Checked == true)
            {
                string edad = mkt_edad.Text;
                NE_prestaciones Prestaciones = new NE_prestaciones();
                DataTable tabla = new DataTable();
                if (cb_Edad.Checked == true) 
                {
                    if (mkt_edad.Text != "")
                    {
                        tabla = Prestaciones.Recuperar_Todos(edad.Trim());
                        CargarGrilla(tabla);
                        return;
                    }
                    else 
                    {
                        MessageBox.Show("Inserte EDAD MINIMA");
                        mkt_edad.Focus();
                        return;
                    }
                }           
                
                tabla = Prestaciones.Recuperar_Todos("-1");
                CargarGrilla(tabla);
                return;
            }

            //FILTRO CODIGO PRESTACION
            if (rb_codigoPrestacion.Checked == true)
            {
                string codigoPrestacion = mkt_codigoPrestacion.Text;
                if (mkt_codigoPrestacion.Text == "")
                {
                    MessageBox.Show("Inserte Codigo de la Prestacion");
                    mkt_codigoPrestacion.Focus();
                }
                else
                {
                    NE_prestaciones Prestaciones = new NE_prestaciones();
                    CargarGrilla(Prestaciones.Recuperar_Patron_CodigoPrestacion(codigoPrestacion));
                    return;
                }
            }

           
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
                    grid_Prestaciones.Rows[i].Cells[0].Value = tabla.Rows[i]["_CodPrestacion"].ToString();
                    grid_Prestaciones.Rows[i].Cells[2].Value = tabla.Rows[i]["_Descripcion"].ToString();
                    grid_Prestaciones.Rows[i].Cells[1].Value = tabla.Rows[i]["_EdadMinima"].ToString();
                }
            }
        }

        private void Frm_ABM_Prestaciones_Load(object sender, EventArgs e)
        {
            
        }
    }
}
