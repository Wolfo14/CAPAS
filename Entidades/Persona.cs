using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        #region Attributes

        private int id;
        private string nombre;
        private string email;

        

     

        


       

        #endregion

        #region Getters&Setters
        
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
        #endregion

        #region Contructors
        public Persona()
        {

        }
        public Persona(int id, string nombre, string email)
        {
            this.id = id;
            this.nombre = nombre;
            this.email = email;
        }

        #endregion



        

        
    }
}
