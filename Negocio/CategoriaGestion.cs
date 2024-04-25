using ABMProductos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{

   

    public class CategoriaGestion
    {
        public List<Categoria> Listado()
        {
            var Lista = new List<Categoria>();

            AccesoBd Acceso = new AccesoBd();

            try
            {
                Acceso.setQuery("SELECT Id,Descripcion FROM Categorias");
                Acceso.ejecutarLectura();

                while (Acceso.Lector.Read())
                {
                    var aux = new Categoria();
                    aux.Id = (int)Acceso.Lector["Id"];
                    aux.Descripcion = (string)Acceso.Lector["Descripcion"];
                    Lista.Add(aux);

                }


                return Lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }finally {
                Acceso.cerrarConexion();
            }    


        }


    }
}
