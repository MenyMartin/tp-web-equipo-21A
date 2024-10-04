using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PromoWeb
{
    public partial class EleccionPremio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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