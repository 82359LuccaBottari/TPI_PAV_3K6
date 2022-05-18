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
            string codigoPrestacion = mkt_codigoPrestacion.Text;
            //FILTROS TODOS C/S EDAD
            grid_Prestaciones.Rows.Clear();
            if (rb_todos.Checked == true)
            {
                string edad = mkt_edad.Text;
                NE_prestaciones Prestaciones = new NE_prestaciones();
                DataTable tabla = new DataTable();
                
                if (mkt_edad.Text != "" && mkt_codigoPrestacion.Text == "")
                {
                    tabla = Prestaciones.Recuperar_Edad(edad.Trim());
                    CargarGrilla(tabla);
                    return;
                }
                if (mkt_codigoPrestacion.Text != "")
                {                    
                    CargarGrilla(Prestaciones.Recuperar_Patron_CodigoPrestacion(codigoPrestacion));
                    return;
                }               
                CargarGrilla(Prestaciones.Recuperar_Todos());
                return;

            }

            //FILTRO CODIGO PRESTACION

            if (mkt_codigoPrestacion.Text != "")
            {
                NE_prestaciones Prestaciones = new NE_prestaciones();
                CargarGrilla(Prestaciones.Recuperar_Patron_CodigoPrestacion(codigoPrestacion));
                return;
            }
            else 
            {
                MessageBox.Show("Indique codigo de prestacion o busqueda por todo");
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

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            NE_prestaciones prestaciones = new NE_prestaciones();
            prestaciones.Pp_CodigoPrestacion = mkt_codigoPrestacion.Text;
            prestaciones.Pp_Descripcion = txt_Descripcion.Text;
            prestaciones.Pp_EdadMinima = mkt_edad.Text;
            DataTable tabla = new DataTable();
            string codigo = mkt_codigoPrestacion.Text.Trim();
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            if (codigo != "")
            {

                tabla = prestaciones.Recuperar_Patron_CodigoPrestacion(codigo);
            }
            else
            {
                MessageBox.Show("Ingrese código de prestación");
                mkt_codigoPrestacion.Focus();
                return;
            }

            if (tabla.Rows.Count > 0)
            {

                MessageBox.Show("Codigo de prestación ya utilizado");
                mkt_codigoPrestacion.Focus();
            }
            else
            {
                if (txt_Descripcion.Text != "" && mkt_edad.Text != "")
                {
                    prestaciones.Insetar();
                    MessageBox.Show("Prestación agregada");
                    LimpiarCampos();

                }
                else
                {
                    MessageBox.Show("Complete campos");
                }

            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            NE_prestaciones prestaciones = new NE_prestaciones();
            string codigo = mkt_codigoPrestacion.Text.Trim();
           
            if (codigo != "")
            {
                DataTable tabla = new DataTable();
                tabla = prestaciones.Recuperar_Patron_CodigoPrestacion(codigo);
                if (tabla.Rows.Count == 1)
                {
                    if (mkt_codigoPrestacion.Text.Trim() != "")
                    {
                        prestaciones.Eliminar(codigo);
                        MessageBox.Show("Eliminación exitosa");
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Inserte Codigo de prestacion");
                        mkt_codigoPrestacion.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Inserte codigo");
                    mkt_codigoPrestacion.Focus();
                }

            }
            else 
            {
                MessageBox.Show("Inserte un codigo de prestación válido");
                mkt_codigoPrestacion.Focus();
            }
            
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            NE_prestaciones prestaciones = new NE_prestaciones();
            string codigo = mkt_codigoPrestacion.Text;
            DataTable tabla = new DataTable();
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            
            if (codigo != "")
            {
                tabla = prestaciones.Recuperar_Patron_CodigoPrestacion(codigo);
                if (txt_Descripcion.Text != "" && mkt_edad.Text != "")
                {
                    prestaciones.Pp_Descripcion = txt_Descripcion.Text;
                    prestaciones.Pp_EdadMinima = mkt_edad.Text;
                    prestaciones.Modificar(codigo);
                    MessageBox.Show("Modificación exitosa");
                    LimpiarCampos();

                }
                else
                {
                    GenerarDatos(codigo);
                    MessageBox.Show("Ingrese datos");
                    mkt_edad.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ingrese codigo");
                mkt_codigoPrestacion.Focus();
            }
        }
        private void LimpiarCampos()
        {
            mkt_codigoPrestacion.Text = "";
            txt_Descripcion.Text = "";
            mkt_edad.Text = "";
            rb_todos.Checked = false;
            
        }
        private void GenerarDatos(string codigo)
        {
            NE_prestaciones prestaciones = new NE_prestaciones();
            DataTable tabla = new DataTable();
            tabla = prestaciones.Recuperar_Patron_CodigoPrestacion(codigo);
            string descripcion = tabla.Rows[0]["_Descripcion"].ToString();
            string edad = tabla.Rows[0]["_EdadMinima"].ToString();
            txt_Descripcion.Text = descripcion;
            mkt_edad.Text = edad;
            return;

        }
        
    }
}
