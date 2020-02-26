using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AccesoADatos
{
    public class conexionDB
    {
        private string connectionString = "Data Source=UAM-HD-LBPF2-12\\SQL2016;Initial Catalog=Progra3;User ID=userPR3;Password=Copeterojo1";
        public void ConexionSQLNoQuery(string sql)
        {
            SqlConnection cnn;
            SqlCommand cmd;

            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery(); //no retorna desde la BD
                //SqlDataReader resultado = cmd.ExecuteReader();
                cmd.Dispose(); //cierro el comando
                Console.WriteLine(" ExecuteNonQuery in SqlCommand executed !!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! " + ex.Message);
            }
            // Closing the connection  
            finally
            {
                cnn.Close(); //cierra conexion con BD
            }
        }


        public SqlDataReader ConexionSQLQuery(string sql) //retorno el data reader
        {
            SqlConnection cnn;
            SqlCommand cmd;
            Entidades.Persona estudiante = new Entidades.Persona();

            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                //cmd.ExecuteNonQuery();
                SqlDataReader resultado = cmd.ExecuteReader(); //retorna desde la BD
                cmd.Dispose();
                if (resultado.HasRows) //consulta si el dataReader tiene rows
                {
                    //Console.WriteLine("{0}\\t{1}\\{2}t", resultado.GetInt32(0), resultado.GetString(1), resultado.GetString(2)); //me escribe el resultado //Una variante para mostrar los datos como tipo toString resultado[0].ToString();
                    cnn.Close();
                    return resultado;
                    
                }              
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! " + ex.Message);
            }
            // Closing the connection  
            finally
            {
                cnn.Close();
                
            }
            return null;
        }






        //public void ConexionADO(string sql)
        //{
        //    try
        //    {
        //        SqlDataAdapter adapter = new SqlDataAdapter(sql, connectionString);
        //        DataSet ds = new DataSet(); //ds = donde se guarda la informacion
        //        adapter.Fill(ds); //el adapter me carga los datos al DataSet
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Can not open connection ! " + ex.Message);

        //        //tarea: Hacer un dataset y hacer tablas, columnas y rows

        //    }
        //}
    }
}
