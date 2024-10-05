using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PromoWeb
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVoucher_Click(object sender, EventArgs e)
        {
            string voucher = txtVoucher.Text;
            ArticuloNegocio negocio = new ArticuloNegocio();
            bool ok = negocio.checkVoucher(voucher);

            if (ok==true)
            {
                Response.Redirect("EleccionPremio.aspx");
            }


            
        }
    }
}