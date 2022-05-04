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
    internal class NE_afiliados
    {
        Be_Acceso_Datos _BD = new Be_Acceso_Datos();
        public DataTable RecuperarTodos()
        {
            string sql = @"SELECT a.*, c.Descripcion as n_CodCategoria"
                        + " FROM afiliados a join categorias c"
                        + " on a._CodCategoria = c.CodCategoria";
            return _BD.EjecutarSelect(sql);
        }
        public DataTable Recuperar_x_Categorias(string CodCat)
        {
            string sql = @"SELECT a.*, c.Descripcion as n_CodCategoria"
                        + " FROM afiliados a join categorias c"
                        + " on a._CodCategoria = c.CodCategoria"
                        + " WHERE a._CodCategoria = " + CodCat;
            return _BD.EjecutarSelect(sql);
        }
        public DataTable Recuperar_x_NroAfiliado(string Nro_Afiliado)
        {
            string sql = @"SELECT a.*, c.Descripcion as n_CodCategoria"
                        + " FROM afiliados a join categorias c"
                        + " on a._CodCategoria = c.CodCategoria"
                        + " WHERE a._NroAfiliado like '%" + Nro_Afiliado.Trim() + "%'";
            return _BD.EjecutarSelect(sql);
        }
    }

}
