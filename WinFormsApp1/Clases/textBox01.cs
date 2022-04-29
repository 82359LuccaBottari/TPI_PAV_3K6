using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPPAV1_Auditoria.Clases
{
    class textBox01 : TextBox
    {
        public string Pp_tabla { get; set; }
        public string Pp_combo { get; set; }
        public bool Pp_validable { get; set; }
        public string Pp_MensajeError { get; set; }

    }
}
