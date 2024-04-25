using ABMProductos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MarcaGestion
    {

        public List <Marca> Listado()
        {
        AccesoBd Acceso = new AccesoBd();

            var Lista = new List<Marca>();   
            try
            {
                Acceso.setQuery("SELECT Id, Descripcion FROM Marcas");
                Acceso.ejecutarLectura();

                while (Acceso.Lector.Read())
                {
                    var aux = new Marca();
                    aux.Id = (int)Acceso.Lector["Id"];
                    aux.Descripcion = (string)Acceso.Lector["Descripcion"];

                    Lista.Add(aux);

                }
                return Lista;


            }
            catch (Exception)
            {

                throw;
            }
            finally{
                Acceso.cerrarConexion();    
            }

        }
    }
}
