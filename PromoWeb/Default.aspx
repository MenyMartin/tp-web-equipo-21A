<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PromoWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">PROMO GANÁ</h1>
            <p class="lead">Cargá tu voucher y luego podrás elegir por que premio participar.</p>            
        </section>

        <section>
            <div>
                <asp:Label ID="lblVoucher" runat="server" Text="Ingresá tu voucher"></asp:Label>
                <asp:TextBox ID="txtVoucher" runat="server"></asp:TextBox>
                <asp:Button ID="btnVoucher" runat="server" OnClick="btnVoucher_Click" Text="Aceptar" />
            </div>
        </section>
    </main>

</asp:Content>
