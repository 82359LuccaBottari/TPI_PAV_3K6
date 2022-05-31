using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WinFormsApp1.Clases
{
    public class Be_Acceso_Datos
    {
        
        public enum EstadoAccionBD { correcto, error };
        public enum EstadoTransaccion { correcta, error };
        public enum TipoConexion { simple, transaccion }
        public enum TipoEstado { correcto, error, sinTransaccion }

        SqlConnection Conexion = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        SqlTransaction Transaccion;
        TipoEstado ControlTransaccion = TipoEstado.correcto;
        TipoConexion ControlConexion = TipoConexion.simple;
        string cadena_conexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K6G03_2022;Persist Security Info=True;User ID=BD3K6G03_2022;Password=BDG03_6578";

        public void IniciarTransaccion()
        {
            ControlConexion = TipoConexion.transaccion;
            ControlTransaccion = TipoEstado.correcto;
        }
        public TipoEstado FinalizarTransaccion()
        {          
            if (ControlConexion == TipoConexion.simple)
            {
                return TipoEstado.sinTransaccion;
            }               
            
            if (ControlTransaccion== TipoEstado.correcto)
            {                
                Transaccion.Commit();
            }
            else
            {                
                Transaccion.Rollback();
            }
            
            ControlConexion = TipoConexion.simple;            
            Cerrar();            
            return ControlTransaccion;
        }
        
        public void CerrarTransaccion()
        {
            if (ControlConexion == TipoConexion.transaccion)
            {
                if (ControlTransaccion == TipoEstado.correcto)
                {
                    Transaccion.Commit();                    
                }
                else
                {
                    Transaccion.Rollback();
                }
                ControlConexion = TipoConexion.simple;
                Cerrar();
            }
        }
        private string EjecutarNoSelect(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ControlTransaccion = TipoEstado.error;
                MessageBox.Show("Error con la Base de Datos" + "\n"
                + "En el comando:" + "\n"
                + sql + "\n"
                + "El mensaje es:" + "\n"
                + e.Message);
            }
            if (sql.ToUpper().IndexOf("INSERT") >= 0)
            {
                DataTable tabla = new DataTable();
                Cmd.CommandText = "SELECT @@Identity";
                try
                {
                    tabla.Load(Cmd.ExecuteReader());
                }
                catch (Exception e)
                {
                    ControlTransaccion = TipoEstado.error;
                    MessageBox.Show("Error con la Base de Datos" + "\n"
                    + "En el comando:" + "\n"
                    + "SELECT @@Identity \n"
                    + "El mensaje es:" + "\n"
                    + e.Message);
                }
                Cerrar();
                return tabla.Rows[0][0].ToString();
            }
            else
            {
                Cerrar();
                return "";
            }
        }

        private void Conectar()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.ConnectionString = cadena_conexion;
                Conexion.Open();
                Cmd.Connection = Conexion;
                Cmd.CommandType = CommandType.Text;
                if (ControlConexion == TipoConexion.transaccion)
                {
                    Transaccion = Conexion.BeginTransaction(IsolationLevel.ReadCommitted);
                    Cmd.Transaction = Transaccion;
                }
            }

        }
        private void Cerrar()
        {
            if (ControlConexion == TipoConexion.simple)
            {
                Conexion.Close();
            }
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
        public void Insertar (string sqlInsertar)
        {
            Conectar();
            Cmd.CommandText = sqlInsertar;
            Cmd.ExecuteNonQuery();
            Cerrar();
        }
        public string Validar(string obj)
        {
            string objeto = "";
            string query = "SELECT _CodPrestacion FROM Prestaciones WHERE _CodPrestacion = @objeto";
            try
            {
                Cmd = new SqlCommand(query, Conexion);
                Conexion.Open();
                Cmd.Parameters.AddWithValue("@objeto", obj);

                objeto = Cmd.ExecuteScalar().ToString();
            }
            catch(Exception ex)
            {
            }
            finally 
            {
                Conexion.Close();
            }
            return objeto;
        }
        public DataTable Consultar(string comando)
        {
            // conecta con la base de datos
            Conectar();
            // se asigna el comando SELECT a ejecutar
            Cmd.CommandText = comando;
            // se crea una tabla donde recibir los datos calculado por el SELECT
            DataTable tabla = new DataTable();
            try
            {
                // dos tareas en simultaneo, se dispara la Consultar con el comando
                // cmd.ExecuteReader(). Se carga la tabla (tabla.Load) con los valores 
                // calculados por el comando SELECT en la base de datos 
                tabla.Load(Cmd.ExecuteReader());
            }
            catch (Exception e)
            {
                // mensaje de error que se emite cuando se produjo un error en el
                // comando ejecutado anteriormente por cmd.ExecuteReader
                MessageBox.Show("Hubo un error en la Base de Datos\n"
                    + "Con el comando: \n"
                    + comando + "\n"
                    + "El error en la base de datos:\n"
                    + e.Message);
                // cambia el control de trasacción por el error detectado
                ControlTransaccion = TipoEstado.error;
                Cerrar();
                return tabla;
            }
            Cerrar();
            return tabla;
        }
        private TipoEstado EjecutarIns_Upd_Del(string comando)
        {
            Conectar();
            Cmd.CommandText = comando;
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un error en la Base de Datos\n"
                + "Con el comando: \n"
                + comando + "\n"
                + "El error en la base de datos:\n"
                + e.Message);
                ControlTransaccion = TipoEstado.error;
                return ControlTransaccion;
            }
            Cerrar();
            return ControlTransaccion;
        }
        public TipoEstado Insertar_T(string comando)
        {
            return EjecutarIns_Upd_Del(comando);
        }
        /// <summary>
        /// PROCEDIMIENTO PARA EJECUTAR COMANDO UPDATE DEL SQL
        /// </summary>
        /// <param name="comando"></param>
        public TipoEstado Modificar_T(string comando)
        {
            return EjecutarIns_Upd_Del(comando);
        }
        /// <summary>
        /// PROCEDMIMIENTO PARA EJECUTAR COMANDO DELETE DEL SQL
        /// </summary>
        /// <param name="comando"></param>
        public TipoEstado Borrar_T(string comando)
        {
            return EjecutarIns_Upd_Del(comando);
        }
    }


}