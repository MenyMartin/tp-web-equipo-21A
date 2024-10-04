<%@ Page Title="EleccionPremio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EleccionPremio.aspx.cs" Inherits="PromoWeb.EleccionPremio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <h1>Elegí por que premio querés participar</h1>
        <section>
            <div class="card-group">
                <div class="card">
                    <img src="..." class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title">Mochila porta notebook</h5>
                        <p class="card-text">Genial para el trabajo o la facu</p>
                    </div>
                    <div class="card-footer">
                        <asp:Button ID="btnDetalleMochila" runat="server" OnClick="btnDetalle_Click" Text="Ver premio" />
                        <asp:Button ID="btnMochila" runat="server" OnClick="btnEleccion_Click" Text="Quiero la mochila" />
                    </div>
                </div>
                <div class="card">
                    <img src="..." class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title">Mouse gamer Hero G502</h5>
                        <p class="card-text">Para tener la precisión en tu mano</p>
                    </div>
                    <div class="card-footer">
                        <asp:Button ID="btnDetalleMouse" runat="server" OnClick="btnDetalle_Click" Text="Ver premio" />
                        <asp:Button ID="btnMouse" runat="server" OnClick="btnEleccion_Click" Text="Quiero el mouse" />
                    </div>
                </div>
                <div class="card">
                    <img src="..." class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title">Teclado mecanico 75% RK M75</h5>
                        <p class="card-text">Lo mejor para jugar o para trabajar</p>
                    </div>
                    <div class="card-footer">
                        <asp:Button ID="btnDetalleTeclado" runat="server" OnClick="btnDetalle_Click" Text="Ver premio" />
                        <asp:Button ID="btnTeclado" runat="server" OnClick="btnEleccion_Click" Text="Quiero el teclado" />
                    </div>
                </div>
            </div>
        </section>


        <section>
            <div>
                <a href="Default">volver</a>
            </div>
        </section>



    </main>



</asp:Content>

