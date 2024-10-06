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

        public void cargarCliente(Cliente cliente, string voucher, string id)
        {

            AccesoDatos datos = new AccesoDatos();
            Voucher voucherObj = new Voucher();
            try
            {
                datos.setearConsulta("SELECT COUNT(*) FROM Clientes WHERE Documento = @documento");
                datos.setearParametro("@documento", cliente.documento);
                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {
                    int existe = datos.Lector.GetInt32(0);
                    if (existe > 0)
                    {
                        try
                        {
                            datos.setearConsulta("UPDATE Clientes " +
                                "SET Nombre = @nombre, Apellido = @apellido, Email = @email, Direccion = @direccion, Ciudad = @ciudad, CP = @cp " +
                                    "WHERE Documento = @documento");
                            datos.setearParametro("@nombre", cliente.nombre);
                            datos.setearParametro("@apellido", cliente.apellido);
                            datos.setearParametro("@email", cliente.email);
                            datos.setearParametro("@direccion", cliente.direccion);
                            datos.setearParametro("@ciudad", cliente.ciudad);
                            datos.setearParametro("@cp", cliente.codigoPostal);
                            datos.ejecutarAccion();
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine("Error al verificar ID de cliente del voucher: " + ex.Message);
                        }

                        finally { datos.cerrarConexion(); }
                    }
                    else
                    {

                        datos.setearConsulta("insert into Clientes (Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP) " +
                            "values (@documento, @nombre, @apellido, @email, @direccion, @ciudad, @cp)");
                        datos.setearParametro("@documento", cliente.documento);
                        datos.setearParametro("@nombre", cliente.nombre);
                        datos.setearParametro("@apellido", cliente.apellido);
                        datos.setearParametro("@email", cliente.email);
                        datos.setearParametro("@direccion", cliente.direccion);
                        datos.setearParametro("@ciudad", cliente.ciudad);
                        datos.setearParametro("@cp", cliente.codigoPostal);
                        datos.ejecutarAccion();

                    }
                }             


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();

            }

            try
            {
                datos.abrirConexion();
                datos.setearConsulta("select Id from Clientes where Documento = @documento");
                datos.setearParametro("@documento", cliente.documento);
                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {
                    voucherObj.idCliente = (int)datos.Lector["Id"];
                    voucherObj.codigo = voucher;
                    voucherObj.fechaCanje = DateTime.Now;
                    voucherObj.idArticulo = id;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();

            }

            try
            {
                datos.abrirConexion();
                datos.setearConsulta("UPDATE Vouchers SET IdCliente = @idCliente, FechaCanje = @fechaCanje, IdArticulo = @idArticulo WHERE CodigoVoucher = @codigo;");
                datos.setearParametro("@codigo", voucherObj.codigo);
                datos.setearParametro("@idCliente", voucherObj.idCliente);
                datos.setearParametro("@fechaCanje", voucherObj.fechaCanje);
                datos.setearParametro("@idArticulo", voucherObj.idArticulo);
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
