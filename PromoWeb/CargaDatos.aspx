<%@ Page Title="CargaDatos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CargaDatos.aspx.cs" Inherits="PromoWeb.CargaDatos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <section>
        </section>
        <section>
            <div>
                <asp:Label ID="lblDni" runat="server" Text="Ingresá tu DNI (sin comas ni puntos)"></asp:Label>
                <asp:TextBox ID="txtDNI" runat="server"></asp:TextBox>
                <asp:Button ID="btnDNI" runat="server" OnClick="btnDNI_Click" Text="Aceptar" />
            </div>
            <br />
            <br />
            <asp:Label ID="lblAvisoDNI" runat="server" Text="" ForeColor="Red" Visible="false"></asp:Label>
            <br />
            <br />
            <div>

            </div>
            <div>
                <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                <asp:Label ID="lblAvisoNombre" runat="server" Text="" Visible="false"></asp:Label>
            </div>
            <div>
                <asp:Label ID="lblApellido" runat="server" Text="Apellido"></asp:Label>
                <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                <asp:Label ID="lblAvisoApellido" runat="server" Text="" Visible="false"></asp:Label>
            </div>
            <div>
                <asp:Label ID="lblEmail" runat="server" Text="E-mail"></asp:Label>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                <asp:Label ID="lblAvisoEmail" runat="server" Text="" Visible="false"></asp:Label>
            </div>
            <div>
                <asp:Label ID="lblDireccion" runat="server" Text="Dirección"></asp:Label>
                <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
                <asp:Label ID="lblAvisoDireccion" runat="server" Text="" Visible="false"></asp:Label>
            </div>
            <div>
                <asp:Label ID="lblCiudad" runat="server" Text="Ciudad"></asp:Label>
                <asp:TextBox ID="txtCiudad" runat="server"></asp:TextBox>
                <asp:Label ID="lblAvisoCiudad" runat="server" Text="" Visible="false"></asp:Label>
            </div>
            <div>
                <asp:Label ID="lblCP" runat="server" Text="Código postal"></asp:Label>
                <asp:TextBox ID="txtCP" runat="server"></asp:TextBox>
                <asp:Label ID="lblAvisoCP" runat="server" Text="" Visible="false"></asp:Label>
            </div>
            <div>
                <asp:Button ID="btnParticipa" runat="server" OnClick="btnParticipa_Click" Text="Participá!" />
            </div>


        </section>
        <section>
            <div>
                <a href="EleccionPremio">volver</a>
            </div>
        </section>

    </main>

</asp:Content>
