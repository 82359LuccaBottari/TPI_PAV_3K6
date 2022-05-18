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
    
    class NE_odontologo
    {
        public string Pp_Matricula { get; set; }
        public string Pp_Apellido { get; set; }
        public string Pp_Nombre { get; set; }


        public DataTable Recuperar_Todos()
        {
            string sql = "SELECT * FROM Odontologos";
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            return _BD.EjecutarSelect(sql);
        }
        public DataTable Recuperar_Patron_Nombre(string patronNombre)
        {
            string sql = "SELECT * FROM Odontologos WHERE _Nombre like '%"+ patronNombre.Trim() +"%'";
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            return _BD.EjecutarSelect(sql);
        }
        public DataTable Recuperar_Patron_Apellido(string patronApellido)
        {
            string sql = "SELECT * FROM Odontologos WHERE _Apellido like '%" + patronApellido.Trim() + "%'";
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            return _BD.EjecutarSelect(sql);       
        }
        public DataTable Recuperar_Matricula(string patronMatricula)
        {
            string sql = "SELECT * FROM Odontologos WHERE _Matricula like " + patronMatricula ;
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            return _BD.EjecutarSelect(sql);
        }

        public void Insetar()
        {
            string sqlInsertar = @"INSERT INTO Odontologos (_Matricula, _Apellido, _Nombre)"
                                   + " VALUES("
                                   + Pp_Matricula
                                   + ", '"+ Pp_Apellido + "'"
                                   + ", '" + Pp_Nombre + "')";
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            _BD.Insertar(sqlInsertar);
        }
        public void Eliminar(string odontologo)
        {
            string sql = "Delete from Odontologos where _Matricula = '" + odontologo + "'";
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            _BD.EjecutarSelect(sql);
        }
        public void Modificar(string odontologo)
        {
            string sql = "Update Odontologos set _Nombre = '"+Pp_Nombre+"', _Apellido = '"+Pp_Apellido+"' Where _Matricula = "+odontologo.ToString();
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            _BD.EjecutarSelect(sql);
        }
    }   
}
