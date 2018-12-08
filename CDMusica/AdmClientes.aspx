<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdmClientes.aspx.cs" Inherits="CDMusica.AdmClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Estilos/estiloAdministrarUsuYclie.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="min-height: 480px;">
        <div>
            <center>
            <asp:Button CssClass="btns" ID="Button1" runat="server" Text="Crear un nuevo cliente" OnClick="btnCrear" style="margin-top: 20px;"></asp:Button>
        </center>
        </div>
        <br />
        <br />
        <div style="margin-top: 20px;">
            <center>
            <asp:Button CssClass="btns" ID="Button2" runat="server" Text="Modificar un cliente" OnClick="btnModificar"></asp:Button>
        </center>
        </div>
        <br />
        <br />
        <div style="margin-top: 20px;">
            <center>
            <asp:Button CssClass="btns" ID="Button3" runat="server" Text="Eliminar un cliente" OnClick="btnEliminar"></asp:Button>
        </center>
        </div>
    </div>
</asp:Content>
