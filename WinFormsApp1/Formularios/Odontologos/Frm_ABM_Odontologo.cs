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
using TPPAV1_Auditoria.Negocios;

namespace TPPAV1_Auditoria.Formularios.Odontologos
{
    public partial class Frm_ABM_Odontologo : Form
    {
        public Frm_ABM_Odontologo()
        {
            InitializeComponent();
        }

        private void Btn_consulta_Click(object sender, EventArgs e)
        {
            grid_Odontologos.Rows.Clear();
            if (Chk_todos.Checked == true)
            {
                NE_odontologo Odontologo = new NE_odontologo();
                DataTable tabla = new DataTable();
                tabla = Odontologo.Recuperar_Todos();
                CargarGrilla(tabla);
                return;
            }
            if (txt_apellido_nombre.Text != "")
            {
                if (Chk_Nombre.Checked == true) //(Chk_Apellido == false)
                {
                    NE_odontologo Odontologo = new NE_odontologo();
                    CargarGrilla(Odontologo.Recuperar_Patron_Nombre(txt_apellido_nombre.Text));
                    return;
                }
                if (Chk_Apellido.Checked == true) //(Chk_Nombre.Checked == false)
                {
                    NE_odontologo Odontologo = new NE_odontologo();
                    CargarGrilla(Odontologo.Recuperar_Patron_Apellido(txt_apellido_nombre.Text));
                    return;
                }
            }

            if (txt_Matriculas.Text != "")
                {
                    NE_odontologo Odontologo = new NE_odontologo();
                    CargarGrilla(Odontologo.Recuperar_Matricula(txt_Matriculas.Text));
                    return;
                }
        }
        private void CargarGrilla(DataTable tabla)
        {
            if (tabla.Rows.Count == 0)
            {
                grid_Odontologos.Rows.Clear();
            }
            else 
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    grid_Odontologos.Rows.Add(tabla.Rows[i]);
                    grid_Odontologos.Rows[i].Cells[0].Value = tabla.Rows[i]["_Matricula"].ToString();
                    grid_Odontologos.Rows[i].Cells[1].Value = tabla.Rows[i]["_Nombre"].ToString();
                    grid_Odontologos.Rows[i].Cells[2].Value = tabla.Rows[i]["_Apellido"].ToString();
                }
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Frm_odontologo_Alta altas = new Frm_odontologo_Alta();
            altas.ShowDialog();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Frm_Odontologo_Baja bajas = new Frm_Odontologo_Baja();
            bajas.ShowDialog();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        { 
            Frm_odontologo_Modificar modificar = new Frm_odontologo_Modificar();
            modificar.ShowDialog();
        }
    }

}
