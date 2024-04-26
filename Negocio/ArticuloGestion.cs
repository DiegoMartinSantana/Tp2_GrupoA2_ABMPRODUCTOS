﻿using ABMProductos;
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

        public void Add(Articulo Art)
        {
            AccesoBd Acceso = new AccesoBd();

            try
            {
				Acceso.setQuery("INSERT INTO ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,Precio)  VALUES (@cod,@nombre,@desc,@idm,@idc,@precio)");
				Acceso.setParametro("@cod", Art.Codigo);
				Acceso.setParametro("@nombre",Art.Nombre);
                Acceso.setParametro("@desc",Art.Descripcion);
                Acceso.setParametro("@idm",Art.Marca.Id);
                Acceso.setParametro("@idc",Art.Categoria.Id);
				Acceso.setParametro("@precio",Art.Precio);
				//insertamos articulo 
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

        public List<Articulo> Listado()
        {
            AccesoBd Acceso = new AccesoBd();

            var ListaArt = new List<Articulo>();
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


        public List<Articulo> FiltroCriterios(string campo, string criterio, string filtro)
        {

            var Acceso = new AccesoBd();
            try
            {
                string query = "SELECT A.ID,A.CODIGO,A.NOMBRE,A.Descripcion,A.IdMarca,M.Descripcion MarcaDesc , A.IdCategoria,C.Descripcion CatDesc ,A.Precio FROM ARTICULOS AS A INNER JOIN MARCAS AS M ON M.Id = A.IdMarca INNER JOIN CATEGORIAS AS C ON C.Id = A.IdCategoria ";

                query += " Where ";

                if (campo == "Precio")
                {
                    if (criterio == "Mayor a :")
                    {
                        query += " A.Precio > " + filtro;
                    }
                    else if (criterio == "Menor a :")
                    {
                        query += "A.Precio < " + filtro;
                    }
                    else
                    {
                        query += "A.Precio = " + filtro;
                    }
                }
                else
                {
                    if (criterio == "Contiene :")
                    {
                        if (campo == "Categoria")
                        {
                            query += " C.Descripcion LIKE '%" + filtro + "%' ";
                        }
                        else if (campo == "Marca")
                        {
                            query += " M.Descripcion LIKE '%" + filtro + "%' ";

                        }

                    }
                    else if (criterio == "Termina con :")
                    {
                        if (campo == "Categoria")
                        {
                            query += " C.Descripcion LIKE '%" + filtro + "'";
                        }
                        else if (campo == "Marca")
                        {
                            query += " M.Descripcion LIKE '%" + filtro + "'";

                        }
                    }
                    else
                    {
                        if (campo == "Categoria")
                        {
                            query += "C.Descripcion LIKE '" + filtro + "%'";
                        }
                        else if (campo == "Marca")
                        {
                            query += "M.Descripcion LIKE '" + filtro + "%'";

                        }
                    }

                }

                Acceso.setQuery(query);

                Acceso.ejecutarLectura();

                var list = new List<Articulo>();
                while (Acceso.Lector.Read())
                {

                    var aux = new Articulo();
                    aux.Id = (int)Acceso.Lector["Id"];
                    aux.Codigo = (string)Acceso.Lector["Codigo"];
                    aux.Nombre = (string)Acceso.Lector["Nombre"];
                    aux.Descripcion = (string)Acceso.Lector["Descripcion"];
                    aux.Precio = (decimal)Acceso.Lector["Precio"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)Acceso.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)Acceso.Lector["Catdesc"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)Acceso.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)Acceso.Lector["Marcadesc"];


                    list.Add(aux);

                }

                return list;
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
