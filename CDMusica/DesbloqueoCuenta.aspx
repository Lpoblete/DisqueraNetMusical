<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DesbloqueoCuenta.aspx.cs" Inherits="CDMusica.DesbloqueoCuenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://fonts.googleapis.com/css?family=Bungee" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" style="min-height:480px;">
        <tr style="vertical-align:initial;">
            <td>
                <table>
                    <tr>
                        <td colspan="2" align="center">
                            <a class="titu">Desbloquear Cuenta</a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a>Correo:</a>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    
                    <tr style="height: 50px;">
                        <td colspan="2" align="center">
                            <asp:Button ID="btnDesbloquearCuenta" runat="server" Text="Desbloquear Cuenta" OnClick="btnDesbloquear" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <p id="detalle" runat="server" style="font-size:25px; color:blue; font-family: 'Bungee', cursive; "></p>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
