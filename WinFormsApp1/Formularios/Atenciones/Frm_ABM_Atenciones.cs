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
            if (rb_todos.Checked == true)
            {
                
                tabla = Atenciones.Recuperar_Todos();
                CargarGrilla(tabla);
                return;
            }
            if (cb_id.Checked == true) 
            {
                string id = mkt_id.Text;
                tabla = Atenciones.Recuperar_ID(id);
                CargarGrilla(tabla);
                return;
            }
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
                string codigoPrestacion = rb_codigoPrestacion.Text;
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
                string nroElemenento = rb_nroElemento.Text;
                tabla = Atenciones.Recuperar_Patron_NumeroAfiliado(nroElemenento);
                CargarGrilla(tabla);
                return;
            }
            if (rb_matricula.Checked == true)
            {
                string matricula = rb_matricula.Text;
                tabla = Atenciones.Recuperar_Patron_Matricula(matricula);
                CargarGrilla(tabla);
                return;
            }
            if (rb_numeroExpediente.Checked == true)
            {
                string nroExped = rb_numeroExpediente.Text;
                tabla = Atenciones.Recuperar_Patron_NumeroExpediente(nroExped);
                CargarGrilla(tabla);
                return;
            }
            if (rb_codigoDocumento.Checked == true)
            {
                string codDoc = rb_codigoDocumento.Text;
                tabla = Atenciones.Recuperar_Patron_CodigoTipoDocumento(codDoc);
                CargarGrilla(tabla);
                return;
            }
            
            LimpiarCampos();
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
                    grid_Atenciones.Rows[i].Cells[0].Value = tabla.Rows[i]["_Id"].ToString();
                    grid_Atenciones.Rows[i].Cells[1].Value = tabla.Rows[i]["_NroAfiliado"].ToString();
                    grid_Atenciones.Rows[i].Cells[2].Value = tabla.Rows[i]["_CodCateg"].ToString();
                    grid_Atenciones.Rows[i].Cells[3].Value = tabla.Rows[i]["_CodPrestac"].ToString();
                    grid_Atenciones.Rows[i].Cells[4].Value = tabla.Rows[i]["_Fecha_Atenc"].ToString();
                    grid_Atenciones.Rows[i].Cells[5].Value = tabla.Rows[i]["_NroElem"].ToString();
                    grid_Atenciones.Rows[i].Cells[6].Value = tabla.Rows[i]["_CodTipo"].ToString();
                    grid_Atenciones.Rows[i].Cells[7].Value = tabla.Rows[i]["_Matricula"].ToString();
                    grid_Atenciones.Rows[i].Cells[8].Value = tabla.Rows[i]["_Nro_exped"].ToString();

                }
            }
        }

        private void LimpiarCampos()
        {
            rb_codigoCategoria.Checked = false;
            rb_codigoDocumento.Checked = false;
            rb_codigoPrestacion.Checked = false;
            rb_fechaAtención.Checked = false;
            rb_matricula.Checked = false;
            rb_nroAfiliado.Checked = false;
            rb_nroElemento.Checked = false;
            rb_numeroExpediente.Checked = false;
            cb_id.Checked = false;
            rb_todos.Checked = false;
            mkt_id.Text = "";
            mkt_codigoCategoria.Text = "";
            mkt_fechaAtencion.Text = "";
            mkt_numeroAfiliado.Text = "";
            cb_codigoPrestacion.SelectedIndex = -1;
            cb_codigoTipo.SelectedIndex = -1;
            cb_matricula.SelectedIndex = -1;
            cb_numeroElemento.SelectedIndex = -1;
            cb_numeroExped.SelectedIndex = -1;
            return;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (cb_id.Checked == false && mkt_id.Text == "")
            {
                NE_atenciones prestaciones = new NE_atenciones();
                prestaciones.Pp_CodigoPrestacion = cb_codigoPrestacion.Text;
                prestaciones.Pp_CodigoCategoria = mkt_codigoCategoria.Text;
                prestaciones.Pp_CodigoTipo = cb_codigoTipo.Text;
                prestaciones.Pp_FechaAtencion = mkt_fechaAtencion.Text;
                prestaciones.Pp_Matricula = cb_matricula.Text;
                prestaciones.Pp_NroAfiliado = mkt_numeroAfiliado.Text;
                prestaciones.Pp_NumeroElemento = cb_numeroElemento.Text;
                prestaciones.Pp_NumeroExpediente = cb_numeroExped.Text;

                DataTable tabla = new DataTable();
                string codigo = mkt_id.Text.Trim();
                Be_Acceso_Datos _BD = new Be_Acceso_Datos();
                tabla = prestaciones.Recuperar_ID(mkt_id.Text.Trim());
                if (tabla.Rows.Count > 0)
                {

                    MessageBox.Show("Atencion ya registrada");
                    mkt_id.Focus();
                }
                else
                {
                    if (mkt_codigoCategoria.Text != "" && mkt_fechaAtencion.Text != "" && mkt_numeroAfiliado.Text != "" && cb_codigoPrestacion.Text != "" && cb_codigoTipo.Text != "" && cb_matricula.Text != "" && cb_numeroElemento.Text != "" && cb_numeroExped.Text != "")
                    {
                        prestaciones.Insetar();
                        MessageBox.Show("Prestación agregada");
                        LimpiarCampos();
                        return;

                    }
                    else
                    {
                        MessageBox.Show("Complete campos");
                        return;
                    }

                }
            }
            else 
            {
                MessageBox.Show("Verifique que el ID NO este complatado y su Seleccionador no este chequeado"); 
            }
        }


        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            NE_atenciones Atenciones = new NE_atenciones();
            string codigo = mkt_id.Text.Trim();

            if (codigo != "")
            {
                DataTable tabla = new DataTable();
                tabla = Atenciones.Recuperar_ID(codigo);
                
                if (tabla.Rows.Count == 1)
                {
                    Atenciones.Eliminar(codigo);
                    MessageBox.Show("Eliminación exitosa");
                    LimpiarCampos();

                }
                else
                {
                    MessageBox.Show("Inserte codigo");
                    mkt_id.Focus();
                }
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            NE_atenciones Atenciones = new NE_atenciones();
            Atenciones.Pp_CodigoPrestacion = cb_codigoPrestacion.Text;
            Atenciones.Pp_CodigoCategoria = mkt_codigoCategoria.Text;
            Atenciones.Pp_CodigoTipo = cb_codigoTipo.Text;
            Atenciones.Pp_FechaAtencion = mkt_fechaAtencion.Text;
            Atenciones.Pp_Matricula = cb_matricula.Text;
            Atenciones.Pp_NroAfiliado = mkt_numeroAfiliado.Text;
            Atenciones.Pp_NumeroElemento = cb_numeroElemento.Text;
            Atenciones.Pp_NumeroExpediente = cb_numeroExped.Text;
            string codigo = mkt_id.Text;
            DataTable tabla = new DataTable();
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();

            if (codigo != "")
            {
                tabla = Atenciones.Recuperar_ID(codigo);
                if (tabla.Rows.Count == 1)
                {
                    GenerarDatos(codigo);
                    if (mkt_codigoCategoria.Text != "" && mkt_fechaAtencion.Text != "" && mkt_numeroAfiliado.Text != "" && cb_codigoPrestacion.Text != "" && cb_codigoTipo.Text != "" && cb_matricula.Text != "" && cb_numeroElemento.Text != "" && cb_numeroExped.Text != "")
                    {
                        Atenciones.Modificar(codigo);
                        MessageBox.Show("Modificacion Exitosa");
                    }
                }
                else
                {
                    MessageBox.Show("No existe el registro");
                }
                
            }
            else
            {
                MessageBox.Show("Ingrese codigo");
                mkt_id.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void GenerarDatos(string codigo)
        {
            NE_atenciones Atenciones = new NE_atenciones();
            DataTable tabla = new DataTable();
            tabla = Atenciones.Recuperar_ID(codigo);
            string Nroafiliado = tabla.Rows[0]["_NroAfiliado"].ToString();
            string CodCateg = tabla.Rows[0]["_CodCateg"].ToString();
            string CodPrestac = tabla.Rows[0]["_CodPrestac"].ToString();
            string Fecha_Atenc = tabla.Rows[0]["_Fecha_Atenc"].ToString();
            string NroElemento = tabla.Rows[0]["_NroElem"].ToString();
            string CodTipo = tabla.Rows[0]["_CodTipo"].ToString();
            string Matricula = tabla.Rows[0]["_CodCateg"].ToString();
            string Nro_exped = tabla.Rows[0]["_Nro_exped"].ToString();            
            mkt_numeroAfiliado.Text = Nroafiliado;
            mkt_codigoCategoria.Text = CodCateg;            
            cb_codigoPrestacion.Text = CodPrestac;
            mkt_fechaAtencion.Text = Fecha_Atenc;
            cb_numeroElemento.Text = NroElemento;
            cb_codigoTipo.Text = CodTipo;
            cb_matricula.Text = Matricula;
            cb_numeroExped.Text = Nro_exped;
            return;

        }
    }
}
