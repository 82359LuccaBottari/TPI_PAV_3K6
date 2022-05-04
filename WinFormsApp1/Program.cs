using TPPAV1_Auditoria.Formularios.Afiliados;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Frm_Inicio());
            //Application.Run(new Frm_ABM_Afiliados());
            //Application.Run(new TPPAV1_Auditoria.Formularios.Odontologos.Frm_ABM_Odontologo());
            //Application.Run(new TPPAV1_Auditoria.Formularios.Odontologos.Frm_odontologo_Alta());
        }
    }
}