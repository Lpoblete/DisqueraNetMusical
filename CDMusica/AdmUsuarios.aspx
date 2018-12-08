<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdmUsuarios.aspx.cs" Inherits="CDMusica.AdmUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Estilos/estiloAdministrarUsuYclie.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="min-height: 480px;">
        <div>
            <center>
            <asp:Button CssClass="btns" ID="Button2" runat="server" Text="Crear un nuevo Usuario" OnClick="btnCrear" style="margin-top: 20px;"></asp:Button>
        </center>
        </div>
        <br />
        <br />
        <div style="margin-top: 20px;">
            <center>
            <asp:Button CssClass="btns" ID="Button1" runat="server" Text="Modificar un Usuario" OnClick="btnModificar"></asp:Button>
        </center>
        </div>
        <br />
        <br />
        <div style="margin-top: 20px;">
            <center>
            <asp:Button CssClass="btns" ID="Button3" runat="server" Text="Eliminar un Usuario" OnClick="btnEliminar"></asp:Button>
        </center>
        </div>
        <br />
        <br />
        <div style="margin-top: 20px;">
            <center>
            <asp:Button CssClass="btns" ID="Button4" runat="server" Text="Desbloquear Cuenta" OnClick="btnDesbloquear"></asp:Button>
        </center>
        </div>
    </div>
</asp:Content>
