using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp1.Clases
{
    internal class ComboBox01 : ComboBox
    {
        public string? Pp_Pk { get; set; }
        public string? Pp_descripcion { get; set; }
        public string? Pp_tabla { get; set; }

        Be_Acceso_Datos _BD = new Be_Acceso_Datos();
        public void CargarCombo()
        {
            string sql = "SELECT " + Pp_Pk + ", " + Pp_descripcion + " FROM " + Pp_tabla;
            this.DisplayMember = Pp_descripcion;
            this.ValueMember = Pp_Pk;
            this.DataSource = _BD.EjecutarSelect(sql);
        }
    }
}
