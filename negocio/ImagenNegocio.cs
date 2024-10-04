using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> listar()
        {

            List<Imagen> listaImagenes = new List<Imagen>();
            AccesoDatos datosImagen = new AccesoDatos();

            try
            {
                datosImagen.setearConsulta("select Id, ImagenUrl from IMAGENES");
                datosImagen.ejecutarLectura();

                while (datosImagen.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.Id = (int)datosImagen.Lector["Id"];
                    aux.ImagenUrl = (string)datosImagen.Lector["ImagenUrl"];


                    listaImagenes.Add(aux);
                }


                return listaImagenes;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }

            finally
            {
                datosImagen.cerrarConexion();
            }

        }
    }
}
