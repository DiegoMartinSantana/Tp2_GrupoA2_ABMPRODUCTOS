using ABMProductos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Negocio
{
    public class ArticuloGestion
    {
       public List<Articulo> Listado()
        {
			var ListaArt = new List<Articulo>();
			var Acceso = new AccesoBd();
			try
			{
				
				Acceso.setQuery(" SELECT A.ID,A.CODIGO,A.NOMBRE,A.Descripcion,A.IdMarca,M.Descripcion MarcaDesc , A.IdCategoria,C.Descripcion CatDesc ,A.Precio FROM ARTICULOS AS A INNER JOIN MARCAS AS M ON M.Id = A.IdMarca INNER JOIN CATEGORIAS AS C ON C.Id = A.IdCategoria ORDER BY A.Codigo");
				Acceso.ejecutarLectura();

				while(Acceso.Lector.Read())
				{
                    var Art = new Articulo();
					Art.Id = (int)Acceso.Lector["Id"]; 
                    Art.Codigo = (string)Acceso.Lector["Codigo"];
				    Art.Nombre = (string)Acceso.Lector["Nombre"];
					Art.Descripcion = (string)Acceso.Lector["Descripcion"];	
					//Genero la instancia de la Marca porque es un obj de mi clase Art
					Art.Marca = new Marca();	
					Art.Marca.Id = (int)Acceso.Lector["IdMarca"];
					Art.Marca.Descripcion = (string)Acceso.Lector["MarcaDesc"];
					Art.Categoria = new Categoria();	
					Art.Categoria.Id = (int)Acceso.Lector["IdCategoria"];
					Art.Categoria.Descripcion = (string)Acceso.Lector["CatDesc"];
					Art.Precio = (decimal)Acceso.Lector["Precio"];

                    ListaArt.Add(Art);
                }
				return ListaArt;
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
    }
}
