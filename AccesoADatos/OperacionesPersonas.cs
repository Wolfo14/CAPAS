using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace AccesoADatos
{
    public class OperacionesPersonas : Ioperaciones<Entidades.Persona>
    {
        private conexionDB conexionDB = new conexionDB();

        public Persona Buscar(int id)
        {
            //string query = "SELECT * FROM Persona WHERE id="+id;
            string query = string.Format("SELECT * FROM Persona WHERE id={0}", id);

           SqlDataReader resultado =  conexionDB.ConexionSQLQuery(query);
            if (resultado != null)
            {
                while (resultado.NextResult())
                {
                    return new Persona(resultado.GetInt32(0), resultado.GetString(1), resultado.GetString(2));


                }
            }

            return null;
        }

        public List<Persona> BuscarTodos()
        {
            //string query = "SELECT * FROM Persona WHERE id="+id;
            string query = string.Format("SELECT * FROM Persona");

            SqlDataReader resultado = conexionDB.ConexionSQLQuery(query);
            List<Persona> listaPersonas = new List<Persona>(); //creo una nueva lista tipo persona

            if (resultado != null)
            {
                while (resultado.NextResult())
                {

                    listaPersonas.Add(new Persona(resultado.GetInt32(0), resultado.GetString(1), resultado.GetString(2))); //añado un objeto tipo personas a la lista Personas
                    //return new Persona(resultado.GetInt32(0), resultado.GetString(1), resultado.GetString(2));


                }
            }

            return listaPersonas; //retorno la lista de personas
        }

        public void Eliminar(Persona item)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Persona item)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Persona item)
        {
            throw new NotImplementedException();
        }
    }
}
