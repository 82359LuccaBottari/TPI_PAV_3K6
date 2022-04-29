using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WinFormsApp1.Clases
{
    class Be_Acceso_Datos
    {
        SqlConnection Conexion = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        string cadena_conexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K6G03_2022;Persist Security Info=True;User ID=BD3K6G03_2022;Password=BDG03_6578";

        private void Conectar()
        {
            Conexion.ConnectionString = cadena_conexion;
            Conexion.Open();
            Cmd.Connection = Conexion;
            Cmd.CommandType = System.Data.CommandType.Text;

        }
        private void Cerrar()
        {
            Conexion.Close();
        }
        public DataTable EjecutarSelect(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            tabla.Load(Cmd.ExecuteReader());
            Cerrar();
            return tabla;
        }

    }


}