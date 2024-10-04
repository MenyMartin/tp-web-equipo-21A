using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient;
using System.Data;

namespace negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> listaCategoria = new List<Categoria>();
            AccesoDatos datosCategoria = new AccesoDatos();

            try
            {
                datosCategoria.setearConsulta("select Id, Descripcion from CATEGORIAS");
                datosCategoria.ejecutarLectura();

                while (datosCategoria.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.IdCat = (int)datosCategoria.Lector["Id"];
                    aux.DescripcionCat = (string)datosCategoria.Lector["Descripcion"];

                    listaCategoria.Add(aux);
                }

                return listaCategoria;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datosCategoria.cerrarConexion();
            }
            
        }

        public void agregar(Categoria nueva)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO CATEGORIAS (DESCRIPCION) VALUES ('" + nueva.ToString() + "')");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
