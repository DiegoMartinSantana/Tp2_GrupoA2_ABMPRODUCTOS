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

        public void Editar(Marca marcaEdit)
        {
            var Acceso = new AccesoBd();

            try
            {
                Acceso.setQuery("UPDATE MARCAS SET Descripcion = @desc WHERE Id = @id");
                Acceso.setParametro("desc",marcaEdit.Descripcion);
                Acceso.setParametro("id", marcaEdit.Id);
                Acceso.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Acceso.cerrarConexion();
            }


        }


        public void Eliminar(int id)
        {
            var Acceso = new AccesoBd();

            try
            {
                Acceso.setQuery("DELETE FROM Marcas where Id = @id");
                Acceso.setParametro("id", id);
                Acceso.ejecutarAccion();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Acceso.cerrarConexion();
            }
        }
            public bool ExistenciaArticulos(int idMarca)
        {
            var Acceso = new AccesoBd();

            try
            {
                Acceso.setQuery("SELECT TOP(1) Nombre FROM Articulos WHERE IdMarca = @idmarca"); // con que exista uno ya alcanza para no permitir borrar
                Acceso.setParametro("idmarca", idMarca);
                Acceso.ejecutarAccion();
                while (Acceso.Lector.Read())
                {
                    string aux = (string)Acceso.Lector["Nombre"];
                    if (string.IsNullOrEmpty(aux))
                    {
                        return false;
                    }
                }

                return true;


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Acceso.cerrarConexion();
            }

        }
        public void Add(Marca marca)
        {
            var Acceso = new AccesoBd();


            try
            {
                Acceso.setQuery("INSERT INTO Marcas (Descripcion) VALUES (@desc)");
                Acceso.setParametro("@desc", marca.Descripcion);
                Acceso.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Acceso.cerrarConexion();
            }

        }

        public List<Marca> Listado()
        {
            var Acceso = new AccesoBd();

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
            finally
            {
                Acceso.cerrarConexion();
            }

        }
    }
}
