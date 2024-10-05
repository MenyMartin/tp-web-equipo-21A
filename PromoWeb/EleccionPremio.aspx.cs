using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;

namespace PromoWeb
{
    public partial class EleccionPremio : System.Web.UI.Page
    {
        public List<Articulo> ListaArticulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            ListaArticulos = negocio.listarPremios();
        }

        protected void btnEleccion_Click(object sender, EventArgs e)
        {
            Response.Redirect("CargaDatos.aspx");
        }

        protected void btnDetalle_Click(object sender, EventArgs e)
        {
            Response.Redirect("Detalle.aspx");
        }
    }
}