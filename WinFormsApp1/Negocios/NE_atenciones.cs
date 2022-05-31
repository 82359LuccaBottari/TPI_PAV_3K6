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
    internal class NE_atenciones
    {
        public string Pp_NroAfiliado { get; set; }
        public string Pp_CodigoPrestacion { get; set; }
        public string Pp_CodigoCategoria { get; set; }
        public string Pp_FechaAtencion { get; set; }
        public string Pp_NumeroElemento { get; set; }
        public string Pp_CodigoTipo { get; set; }
        public string Pp_Matricula { get; set; }
        public string Pp_NumeroExpediente { get; set; }



        public DataTable Recuperar_Todos()
        {
            string sql = "SELECT * FROM Atenciones";
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();            
            return _BD.Consultar(sql);

        }
        public DataTable Recuperar_ID(string id)
        {
            string sql = "SELECT * FROM Atenciones WHERE _Id =" + id;
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            return _BD.Consultar(sql);

        }

        public DataTable Recuperar_Patron_NumeroAfiliado(string patronNumeroAfiliado)
        {
            string sql = "SELECT * FROM Atenciones WHERE _NroAfiliado like " + patronNumeroAfiliado;
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            return _BD.Consultar(sql);
        }

        public DataTable Recuperar_Patron_CodigoPrestacion(string patronCodigoPrestacion)
        {
            string sql = "SELECT * FROM Atenciones WHERE _CodPrestac like " + patronCodigoPrestacion;
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            return _BD.Consultar(sql);
        }

        public DataTable Recuperar_Patron_CodigoCategoria(string patronCodigoCategoria)
        {
            string sql = "SELECT * FROM Atenciones WHERE _CodCateg like " + patronCodigoCategoria;
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            return _BD.Consultar(sql);
        }

        public DataTable Recuperar_Patron_FechaAtencion(string patronFechaAtencion)
        {
            string sql = "SELECT * FROM Atenciones WHERE _Fecha_Atenc like " + patronFechaAtencion;
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            return _BD.Consultar(sql);
        }

        public DataTable Recuperar_Patron_NumeroElemento(string patronNumeroElemento)
        {
            string sql = "SELECT * FROM Atenciones WHERE _NroElem like " + patronNumeroElemento;
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            return _BD.Consultar(sql);
        }

        public DataTable Recuperar_Patron_CodigoTipoDocumento(string patronCodigoTipoDocumento)
        {
            string sql = "SELECT * FROM Atenciones WHERE _CodTipo like " + patronCodigoTipoDocumento;
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            return _BD.Consultar(sql);
        }

        public DataTable Recuperar_Patron_Matricula(string patronMatricula)
        {
            string sql = "SELECT * FROM Atenciones WHERE _Matricula like " + patronMatricula;
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            return _BD.Consultar(sql);
        }

        public DataTable Recuperar_Patron_NumeroExpediente(string patronNumeroExpediente)
        {
            string sql = "SELECT * FROM Atenciones WHERE _Nro_exped like " + patronNumeroExpediente;
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            return _BD.Consultar(sql);
        }

        public Be_Acceso_Datos.TipoEstado Insetar()
        {
            string sqlInsertar = @"INSERT INTO Atenciones (_NroAfiliado, _CodCateg, _Fecha_Atenc, _NroElem, _CodTipo, _Matricula, _Nro_exped, _CodPrestac)"
                                   + " VALUES("
                                   + Pp_NroAfiliado.ToString()
                                   + ", '" + Pp_CodigoCategoria.ToString() + "'"
                                   + ", '" + Pp_FechaAtencion.ToString() + "'"
                                   + ", '" + Pp_NumeroElemento.ToString() + "'"
                                   + ", '" + Pp_CodigoTipo.ToString() + "'"
                                   + ", '" + Pp_Matricula.ToString() + "'"
                                   + ", '" + Pp_NumeroExpediente.ToString() + "'"
                                   + ", '" + Pp_CodigoPrestacion.ToString() + "')";
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            _BD.IniciarTransaccion();
            _BD.Insertar(sqlInsertar);
            return _BD.FinalizarTransaccion();
        }
        public Be_Acceso_Datos.TipoEstado Eliminar (string id)
        {
            string sql = "Delete from Atenciones where _Id = '" + id + "'";
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            _BD.IniciarTransaccion();
            _BD.Borrar_T(sql);
            return _BD.FinalizarTransaccion();
        }
        public Be_Acceso_Datos.TipoEstado Modificar (string ID)
        {
            string sql = @"Update Atenciones set 
                            _NroAfiliado = '" + Pp_NroAfiliado 
                            + "', _CodCateg = '" + Pp_CodigoCategoria 
                            + "', _NroElem =  '" + Pp_NumeroElemento 
                            + "', _CodTipo =  '" + Pp_CodigoTipo
                            + "', _Matricula =  '" + Pp_Matricula
                            + "', _Nro_exped =  '" + Pp_NumeroExpediente
                            + "', _CodPrestac =  '" + Pp_CodigoPrestacion
                            + "', _Fecha_Atenc =  '" + Pp_FechaAtencion
                            + " Where _Id = " + ID;
            Be_Acceso_Datos _BD = new Be_Acceso_Datos();
            _BD.IniciarTransaccion();
            _BD.Modificar_T(sql);
            return _BD.FinalizarTransaccion();
        }
    }
}
