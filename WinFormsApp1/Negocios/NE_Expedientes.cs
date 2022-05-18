using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinFormsApp1.Clases;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;
using TPPAV1_Auditoria.Clases;


namespace TPPAV1_Auditoria.Negocios
{
    internal class NE_Expedientes
    {
        Be_Acceso_Datos _BD = new Be_Acceso_Datos();

        public DataTable RecuperarTodos()
            
        {
            string sql = "SELECT * From Expedientes";

           
            DataTable tabla = new DataTable ();
            return _BD.EjecutarSelect(sql);
            


        }

        public DataTable Recuperar_x_nr_Expediente(string Nr_De_Expedientes)

        {
            
            string sql = "SELECT * From Expedientes  WHERE NroExped  like '%" + Nr_De_Expedientes.Trim() + "%'";
            DataTable tabla = new DataTable();
            return _BD.EjecutarSelect(sql);

        }
        public DataTable Recuperar_x_Fecha_De_Inicio(string Fecha_inicio)

        {

            string sql = "SELECT * From Expedientes WHERE FechaInicio like '%" + Fecha_inicio + "%'";
            DataTable tabla = new DataTable();
            return _BD.EjecutarSelect(sql);

        }
        public DataTable Recuperar_x_Reintegro(string Reintegro)

        {

            string sql = "SELECT * From Expedientes WHERE Reintegro like '%" + Reintegro + "%'";
            DataTable tabla = new DataTable();
            return _BD.EjecutarSelect(sql);

        }
    }
}
