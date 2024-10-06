<%@ Page Title="EleccionPremio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EleccionPremio.aspx.cs" Inherits="PromoWeb.EleccionPremio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <h1>Elegí por que premio querés participar</h1>
        <section>
            <div class="card-group">
                <asp:Repeater ID="rptArticulos" runat="server">
                    <ItemTemplate>
                        <div class="card">
                            <div id="carouselExample" class="carousel slide">
                                <div class="carousel-inner">
                                    <div class="carousel-item active">
                                        <img src='<%# Eval("Imagen.ImagenUrl") %>' class="d-block w-100" alt="...">
                                    </div>
                                    <div class="carousel-item">
                                        <img src="..." class="d-block w-100" alt="...">
                                    </div>
                                    <div class="carousel-item">
                                        <img src="..." class="d-block w-100" alt="...">
                                    </div>
                                </div>
                                <button class="carousel-control-prev" type="button" data-bs-target="#carouselExample" data-bs-slide="prev">
                                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                                    <span class="visually-hidden">Previous</span>
                                </button>
                                <button class="carousel-control-next" type="button" data-bs-target="#carouselExample" data-bs-slide="next">
                                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                                    <span class="visually-hidden">Next</span>
                                </button>
                            </div>
                            <div class="card-body">
                                <h5 class="card-title"><%# Eval("Nombre") %></h5>
                                <p class="card-text"><%# Eval("Descripcion") %></p>
                            </div>
                            <div class="card-footer">
                                <asp:Button ID="btnPremio" runat="server" Text="Quiero este premio" OnClick="btnEleccion_Click" CommandArgument='<%# Eval("Id") %>' />
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>

                <%--<%
                    foreach (dominio.Articulo premio in ListaArticulos)
                    {%>
                <<div class="card">
                    <div id="carouselExample" class="carousel slide">
                        <div class="carousel-inner">
                            <div class="carousel-item active">
                                <img src="<%:premio.Imagen.ImagenUrl %>" class="d-block w-100" alt="...">
                            </div>
                            <div class="carousel-item">
                                <img src="..." class="d-block w-100" alt="...">
                            </div>
                            <div class="carousel-item">
                                <img src="..." class="d-block w-100" alt="...">
                            </div>
                        </div>
                        <button class="carousel-control-prev" type="button" data-bs-target="#carouselExample" data-bs-slide="prev">
                            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                            <span class="visually-hidden">Previous</span>
                        </button>
                        <button class="carousel-control-next" type="button" data-bs-target="#carouselExample" data-bs-slide="next">
                            <span class="carousel-control-next-icon" aria-hidden="true"></span>
                            <span class="visually-hidden">Next</span>
                        </button>
                    </div>
                    <div class="card-body">
                        <h5 class="card-title"><%:premio.Nombre %></h5>
                        <p class="card-text"><%:premio.Descripcion %></p>                        
                    </div>
                    <div class="card-footer">
                        <asp:Button ID="btnPremio" runat="server"  Text="Quiero este premio" OnClick="btnEleccion_Click"  CommandArgument=<%# Eval("Id") %>/>
                        
                    </div>
                </div>


                <%}%>--%>
            </div>
        </section>


        <section>
            <div>
                <a href="Default">volver</a>
            </div>
        </section>



    </main>



</asp:Content>

