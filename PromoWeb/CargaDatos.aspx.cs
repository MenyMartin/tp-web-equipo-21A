using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
            Cliente cliente = new Cliente();
            int dni;
            bool isValidDNI = int.TryParse(txtDNI.Text, out dni);
            if (!isValidDNI)
            {

                lblAvisoDNI.Text = "Por favor, ingrese un número de DNI válido y presione Aceptar.";
                lblAvisoDNI.ForeColor = System.Drawing.Color.Red;
                lblAvisoDNI.Visible = true;
                return;
            }
            else { cliente.documento = int.Parse(txtDNI.Text); }
                
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || !Regex.IsMatch(txtNombre.Text, @"^[a-zA-Z]+$"))
            {
                lblAvisoNombre.Text = "Por favor, ingrese un valor válido.";
                lblAvisoNombre.ForeColor = System.Drawing.Color.Red;
                lblAvisoNombre.Visible = true;
                return;
            }
            else { lblAvisoNombre.Visible = false; cliente.nombre = txtNombre.Text; }


            if (string.IsNullOrWhiteSpace(txtApellido.Text) || !Regex.IsMatch(txtApellido.Text, @"^[a-zA-Z]+$"))
            {
                lblAvisoApellido.Text = "Por favor, ingrese un valor válido.";
                lblAvisoApellido.ForeColor = System.Drawing.Color.Red;
                lblAvisoApellido.Visible = true;
                return;
            }
            else { lblAvisoApellido.Visible = false; cliente.apellido = txtApellido.Text; }


            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lblAvisoEmail.Text = "Por favor, ingrese un valor válido.";
                lblAvisoEmail.ForeColor = System.Drawing.Color.Red;
                lblAvisoEmail.Visible = true;
                return;
            }
            else { lblAvisoEmail.Visible = false; cliente.email = txtEmail.Text; }


            if (string.IsNullOrWhiteSpace(txtDireccion.Text) || !Regex.IsMatch(txtDireccion.Text, @"^[a-zA-Z0-9\s]+$"))
            {
                lblAvisoDireccion.Text = "Por favor, ingrese un valor válido.";
                lblAvisoDireccion.ForeColor = System.Drawing.Color.Red;
                lblAvisoDireccion.Visible = true;
                return;
            }
            else { lblAvisoDireccion.Visible = false; cliente.direccion = txtDireccion.Text; }


            if (string.IsNullOrWhiteSpace(txtCiudad.Text) || !Regex.IsMatch(txtCiudad.Text, @"^[a-zA-Z\s]+$"))
            {
                lblAvisoCiudad.Text = "Por favor, ingrese un valor válido.";
                lblAvisoCiudad.ForeColor = System.Drawing.Color.Red;
                lblAvisoCiudad.Visible = true;
                return;
            }
            else { lblAvisoCiudad.Visible = false; cliente.ciudad = txtCiudad.Text; }

            int CP;
            bool isValid = int.TryParse(txtCP.Text, out CP);
            if (!isValid)
            {

                lblAvisoCP.Text = "Por favor, ingrese un valor válido.";
                lblAvisoCP.ForeColor = System.Drawing.Color.Red;
                lblAvisoCP.Visible = true;
                return;
            }
            else { lblAvisoCP.Visible = false; cliente.codigoPostal = int.Parse(txtCP.Text); }         
                                   

            ClienteNegocio negocio = new ClienteNegocio();
            negocio.cargarCliente(cliente, Session["voucher"].ToString(), (Session["id"].ToString()));


            string script = "alert('Registro exitoso. Ya estas participando del sorteo'); window.location='Default.aspx';";
            ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
            
        }

        protected void btnDNI_Click(object sender, EventArgs e)
        {
            int dni;
            
            bool isValid = int.TryParse(txtDNI.Text, out dni);

            if (!isValid)
            {
                
                lblAvisoDNI.Text = "Por favor, ingrese un número de DNI válido y presione Aceptar";
                lblAvisoDNI.ForeColor = System.Drawing.Color.Red;
                lblAvisoDNI.Visible = true;
                return; 
            }
            else
            {
            lblAvisoDNI.Text = "Continúe cargando sus datos. Si ya están cargados verifique y presione en Participa!";
            lblAvisoDNI.ForeColor = System.Drawing.Color.Green;
            lblAvisoDNI.Visible = true;
            
            dni = int.Parse(txtDNI.Text);
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
}