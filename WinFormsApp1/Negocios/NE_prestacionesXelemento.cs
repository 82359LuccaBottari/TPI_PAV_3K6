using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WinFormsApp1.Clases;

namespace TPPAV1_Auditoria.Negocios
{
    class NE_prestacionesXelemento
    {
        public string Pp_NroElemento { get; set; }
        public string Pp_CodigoPrestacion { get; set; }
        public string Pp_DiasGarantias { get; set; }
        public string Pp_Id { get; set; }


        public DataTable Recuperar_Prestacion(string prestacion)
        {
            string sql = "SELECT * FROM PrestacXElemento WHERE CodPrestacion = "+prestacion.ToString();
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();            
            return _BD.EjecutarSelect(sql);

        }
        public DataTable Recuperar_Todos()
        {
            string sql = "SELECT * FROM PrestacXElemento";
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            return _BD.EjecutarSelect(sql);
        }


        public DataTable Recuperar_Elemento(string Elemento)
        {
            string sql = "SELECT * FROM PrestacXElemento WHERE NroElemento = " + Elemento;
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            return _BD.EjecutarSelect(sql);
        }
        public DataTable Recuperar_ID(string iD)
        {
            string sql = "SELECT * FROM PrestacXElemento WHERE Id = " + iD;
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            return _BD.EjecutarSelect(sql);
        }


        public void Insetar()
        {
            string sqlInsertar = @"INSERT INTO PrestacXElemento (CodPrestacion, NroElemento, DiasGarantias)"
                                   + " VALUES("
                                   + Pp_CodigoPrestacion.ToString()
                                   + ", '" + Pp_NroElemento.ToString() + "'"
                                   + ", '" + Pp_DiasGarantias.ToString() + "')";
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            _BD.Insertar(sqlInsertar);
        }

        public void Eliminar(string iD)
        {
            string sql = "Delete from PrestacXElemento where Id = '"+iD.ToString()+"'";
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            _BD.EjecutarSelect(sql);
        }

        public void Modificar(string iD)
        {
            string sql = "Update PrestacXElemento set NroELemento = '"+Pp_NroElemento.ToString() + "', DiasGarantias = '"+Pp_DiasGarantias.ToString() + ", CodPrestacion = '"+Pp_CodigoPrestacion.ToString() + "' Where Id = "+iD.ToString();
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            _BD.EjecutarSelect(sql);
        }
    }
}
