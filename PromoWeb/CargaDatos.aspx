<%@ Page Title="CargaDatos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CargaDatos.aspx.cs" Inherits="PromoWeb.CargaDatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <section>
            <div>
                <h1>Elegiste (concatenar premio elegido)</h1>
            </div>
        </section>
        <section>
            <div>
                <asp:Label ID="lblDni" runat="server" Text="Ingresá tu DNI (sin comas ni puntos)"></asp:Label>
                <asp:TextBox ID="txtDNI" runat="server"></asp:TextBox>
                <asp:Button ID="btnDNI" runat="server" Text="Aceptar" />
            </div>


        </section>
        <section>
            <div>
                <a href="EleccionPremio">volver</a>
            </div>
        </section>

    </main>    

</asp:Content>
