using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Clases;
using System.Data;
using System.Windows.Forms;
using TPPAV1_Auditoria.Clases;

namespace TPPAV1_Auditoria.Negocios
{

    class NE_prestaciones
    {
        public string Pp_Descripcion { get; set; }
        public string Pp_CodigoPrestacion { get; set; }
        public string Pp_EdadMinima { get; set; }


        public DataTable Recuperar_Edad(string edadMinima)
        {
            string sql = "SELECT * FROM Prestaciones";
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            if (edadMinima != "-1")
            {
                string sql2 = "SELECT * FROM Prestaciones WHERE _EdadMinima > "+edadMinima;
                return _BD.EjecutarSelect(sql2);

            }
            return _BD.EjecutarSelect(sql);

        }
        public DataTable Recuperar_Todos() 
        {
            string sql = "SELECT * FROM Prestaciones";
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            return _BD.EjecutarSelect(sql);
        }

        
        public DataTable Recuperar_Patron_CodigoPrestacion(string patronCodigoPrestacion)
        {
            string sql = "SELECT * FROM Prestaciones WHERE _CodPrestacion = "+patronCodigoPrestacion;
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            return _BD.EjecutarSelect(sql);
        }


        public void Insetar()
        {
            string sqlInsertar = @"INSERT INTO Prestaciones (_CodPrestacion, _Descripcion, _EdadMinima)"
                                   + " VALUES("
                                   + Pp_CodigoPrestacion.ToString()
                                   + ", '" + Pp_Descripcion.ToString() + "'"
                                   + ", '" + Pp_EdadMinima.ToString() + "')";
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            _BD.Insertar(sqlInsertar);
        }
        
        public void Eliminar(string prestaciones) 
        {
            string sql = "Delete from Prestaciones where _CodPrestacion = '"+prestaciones+"'";
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            _BD.EjecutarSelect(sql);
        }
        
        public void Modificar(string prestaciones) 
        {
            string sql = "Update Prestaciones set _EdadMinima = '"+Pp_EdadMinima+"', _Descripcion = '"+Pp_Descripcion+"' Where _CodPrestacion = "+prestaciones;
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            _BD.EjecutarSelect(sql);
        }
    }
}

