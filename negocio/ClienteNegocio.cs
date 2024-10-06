using dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ClienteNegocio
    {
        public Cliente checkCliente(int dni)
        {
            AccesoDatos datos = new AccesoDatos();
            Cliente cliente = new Cliente();

            try
            {
                datos.setearConsulta("select * from Clientes where Documento = @dni");
                datos.setearParametro("@dni", dni);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {                                       
                        
                        cliente.id = (int)datos.Lector["Id"];
                        cliente.documento = Convert.ToInt32(datos.Lector["Documento"]);
                        cliente.nombre = (string)datos.Lector["Nombre"];
                        cliente.apellido = (string)datos.Lector["Apellido"];
                        cliente.email = (string)datos.Lector["Email"];
                        cliente.direccion = (string)datos.Lector["Direccion"];
                        cliente.ciudad = (string)datos.Lector["Ciudad"];
                        cliente.codigoPostal = (int)datos.Lector["CP"];

                        return cliente;
                    
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al verificar el cliente: " + ex.Message);
            }

            finally { datos.cerrarConexion(); }

            return cliente;
        }
    }
}
