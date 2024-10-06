using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace PromoWeb
{
    public partial class CargaDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string voucher = Session["voucher"].ToString();
            string id = (Session["id"].ToString());
        }

        protected void btnParticipa_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnDNI_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(txtDNI.Text);
            Cliente cliente = new Cliente();
            ClienteNegocio negocio = new ClienteNegocio();
            cliente = negocio.checkCliente(dni);
            txtNombre.Text = cliente.nombre;
            txtApellido.Text = cliente.apellido;
            txtEmail.Text = cliente.email;
            txtDireccion.Text = cliente.direccion;
            txtCiudad.Text = cliente.ciudad;
            txtCP.Text = cliente.codigoPostal.ToString();
        }
    }
}