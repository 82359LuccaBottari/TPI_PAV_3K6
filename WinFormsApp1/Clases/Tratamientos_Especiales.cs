using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Clases;

namespace TPPAV1_Auditoria.Clases
{
    class Tratamientos_Especiales
    {
        public enum Resultado { correcto, error }
        public Resultado Validar (Control.ControlCollection controles)
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name == "textBox01")
                {
                    if (((textBox01)item).Text == "")
                    {
                        MessageBox.Show(((textBox01)item).Pp_MensajeError);
                        ((textBox01)item).Focus();
                        return Resultado.error;
                    }
                }
            }
            return Resultado.correcto;
        }
    }
}
