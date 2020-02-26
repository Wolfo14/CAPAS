using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos
{
    public interface Ioperaciones<T>
    {
        void Insertar(T item);

        T Buscar(int id); //retorno un objeto generico(T) y recibo como parametro de busqueda un id

        List<T> BuscarTodos(); //retorno una lista de valores genericos(T)

        void Modificar(T item);

        void Eliminar(T item);
        
    }
}
