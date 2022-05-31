using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WinFormsApp1.Clases;

namespace TPPAV1_Auditoria.Negocios
{
    class NE_documentoXprestaciones
    {
        public string Pp_CodigoDoc { get; set; }
        public string Pp_CodigoPrestacion { get; set; }       
        public string Pp_Id { get; set; }


        public DataTable Recuperar_Prestacion(string prestacion)
        {
            string sql = "SELECT * FROM DocXPresta WHERE CodPrestacion = " + prestacion.ToString();
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            return _BD.EjecutarSelect(sql);

        }
        public DataTable Recuperar_Todos()
        {
            string sql = "SELECT * FROM DocXPresta";
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            return _BD.EjecutarSelect(sql);
        }

        public DataTable Recuperar_Documento(string Doc)
        {
            string sql = "SELECT * FROM DocXPresta WHERE CodDocum = " + Doc;
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            return _BD.EjecutarSelect(sql);
        }
        public DataTable Recuperar_ID(string iD)
        {
            string sql = "SELECT * FROM DocXPresta WHERE Id = " + iD;
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            return _BD.EjecutarSelect(sql);
        }
        public void Insetar()
        {
            string sqlInsertar = @"INSERT INTO DocXPresta (CodPrestacion, CodDocum)"
                                   + " VALUES("
                                   + Pp_CodigoPrestacion.ToString()
                                   + ", '" + Pp_CodigoDoc.ToString() + "')";                                   
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            _BD.Insertar(sqlInsertar);
        }

        public void Eliminar(string iD)
        {
            string sql = "Delete from DocXPresta where Id = '" + iD.ToString() + "'";
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            _BD.EjecutarSelect(sql);
        }

        public void Modificar(string iD)
        {
            string sql = "Update DocXPresta set CodPrestacion = '" + Pp_CodigoPrestacion.ToString() + "', CodDocum = '" + Pp_CodigoDoc.ToString() + "' Where Id = " + iD.ToString();
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            _BD.EjecutarSelect(sql);
        }
    }
}
