<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CrearCuenta.aspx.cs" Inherits="CDMusica.CrearUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Estilos/estiloCrearUsuario.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" style="min-height: 480px;">
        <tr style="vertical-align:initial;">
            <td>
                <table>
                    <tr>
                        <td colspan="2" align="center">
                            <a class="titu">Crear
                                <asp:Label ID="Label1" runat="server" Text=""></asp:Label></a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a>Correo:</a>
                        </td>
                        <td>
                            <asp:TextBox ID="Correo" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a>Pass:</a>
                        </td>
                        <td>
                            <asp:TextBox ID="Pass" TextMode="Password" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a>Nombre:</a>
                        </td>
                        <td>
                            <asp:TextBox ID="Nombre" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a>Edad:</a>
                        </td>
                        <td>
                            <asp:TextBox ID="Edad" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a>Foto:</a>
                        </td>
                        <td>
                            <asp:FileUpload ID="ImagenUsuario" runat="server" />
                        </td>
                    </tr>
                    <tr style="margin-top: 20px; height: 60px;">
                        <td colspan="3" align="center">
                            <asp:Button ID="Button1" runat="server" Text="Crear Cuenta" OnClick="Button1_Click" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
