<%@ Page Title="EleccionPremio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EleccionPremio.aspx.cs" Inherits="PromoWeb.EleccionPremio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <h1>Elegí por que premio querés participar</h1>
        <section>
            <div class="card-group">
                <%
                    foreach (dominio.Articulo premio in ListaArticulos)
                    {%>
                <div class="card">
                    <img src="<%:premio.Imagen.ImagenUrl %>" class="card-img-top" alt="Responsive image">
                    <div class="card-body">
                        <h5 class="card-title"><%:premio.Nombre %></h5>
                        <p class="card-text"><%:premio.Descripcion %></p>
                        <%Session.Add("id",premio.Id); %>
                    </div>
                    <div class="card-footer">
                         <%-- <asp:Button ID="btnDetalleMochila" runat="server" OnClick="btnDetalle_Click" Text="Ver premio" />--%>
                        <asp:Button ID="btnPremio" runat="server" OnClick="btnEleccion_Click" Text="Quiero este premio" />
                    </div>
                </div>
                <%}%>
            </div>
        </section>


        <section>
            <div>
                <a href="Default">volver</a>
            </div>
        </section>



    </main>



</asp:Content>

