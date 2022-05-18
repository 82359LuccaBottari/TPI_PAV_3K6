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

namespace TPPAV1_Auditoria.Formularios.Expedientes
{
    public partial class Frm_ABM_Expedientes : Form
    {
        public Frm_ABM_Expedientes()
        {
            InitializeComponent();
        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {

            NE_Expedientes Expedientes = new NE_Expedientes();
            DataTable tabla = new DataTable();
            Grid_Expediente.Rows.Clear();
            //muestra  todos  los expeidients con sus diferentes atributos
            if (Chk_Todos.Checked == true)
            {

                tabla = Expedientes.RecuperarTodos();
                CargarGrilla(tabla);
                return;
            }
            //busqueda  por numero de expediente
            if (rb_nro_Expediente.Checked == true)
            {
                if (msk_nro_Expediente.Text.Trim() != "")
                {
                    string nr_Expediente = msk_nro_Expediente.Text;

                    tabla = Expedientes.Recuperar_x_nr_Expediente(nr_Expediente);
                    CargarGrilla(tabla);

                }
                else 
                {
                    MessageBox.Show("Selececione parametro de  busqueda o ingrese el  campode busqueda");
                }
                return;   
            }
            //busqueda por fecha de inicio 
            DateTime fechaNacimiento;
            bool validacionFechainicion = DateTime.TryParse(mkt_fecha_i_Expediente.Text.ToString(), out fechaNacimiento);
            
            if (rb_Fecha_Inicio.Checked == true)
            {
                if (validacionFechainicion == false)
                {
                    MessageBox.Show("¡Introducir fecha de buscada!");
                    mkt_fecha_i_Expediente.Focus();
                }
                else 
                {
                    DateTime Fecha_inicio = DateTime.Parse(mkt_fecha_i_Expediente.Text);
                    DateTime fecha = Fecha_inicio;
                    string dia = "";
                    string mes = "";
                    string año = "";
                    dia = fecha.Date.Day.ToString();
                    if (dia.Length == 1)
                    {
                        dia = "0" + dia;
                    }
                    mes = fecha.Date.Month.ToString();
                    if (mes.Length == 1)
                    {
                        mes = "0" + mes;
                    }
                    año = fecha.Date.Year.ToString();
                    string fechaPar = año + "-" + mes + "-" + dia;
                    tabla = Expedientes.Recuperar_x_Fecha_De_Inicio(fechaPar);
                    CargarGrilla(tabla);
                    return;
                }

               
            }

            //busqueda por reintegro
            if (rb_Reintegro.Checked == true)
            {
                if (msk_Reintegro.Text.Trim() != "")
                {
                    string Reintegro = msk_Reintegro.Text;

                    tabla = Expedientes.Recuperar_x_Reintegro(Reintegro);
                    
                    CargarGrilla(tabla);
                   // Limpiar_campos();
                     
                }
                else
                {
                    MessageBox.Show("Selececione parametro de  busqueda o ingrese el  campode busqueda");
                }
                return;
            }



        }
        //limpiar
        private void Limpiar_campos()
        {
            msk_nro_Expediente.Text = "";
            msk_Reintegro.Text = "";
            mkt_fecha_i_Expediente.Text = "";
            rb_Reintegro.Checked = false;
            rb_nro_Expediente.Checked = false;
            rb_Fecha_Inicio.Checked = false;
            //Grid_Expediente.Rows.Clear();

        }
        private void CargarGrilla(DataTable tabla)
        {
            if (tabla.Rows.Count == 0)
            {
                Grid_Expediente.Rows.Clear();
            }
            else
            {



                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    Grid_Expediente.Rows.Add(tabla.Rows[i]);
                    Grid_Expediente.Rows[i].Cells[0].Value = tabla.Rows[i]["NroExped"].ToString();
                    Grid_Expediente.Rows[i].Cells[1].Value = tabla.Rows[i]["FechaInicio"].ToString();
                    Grid_Expediente.Rows[i].Cells[2].Value = tabla.Rows[i]["Reintegro"].ToString();
                }
            }

        
        }

       




        private void Frm_ABM_Expedientes_Load(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar_campos();   
        }
    }
}
