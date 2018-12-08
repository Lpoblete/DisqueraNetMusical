<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ModificarCuenta.aspx.cs" Inherits="CDMusica.ModificarCuenta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="JQuery/jquery.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" style="min-height: 480px;">
        <tr style="vertical-align:initial;">
            <td>
                <table>
                    <tr>
                        <td colspan="2" align="center">
                            <a class="titu">Modificar 
                                <asp:Label ID="txtTipoCuenta" runat="server" Text=""></asp:Label></a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a>Correo:</a>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
                            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a>Pass:</a>
                        </td>
                        <td>
                            <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a>Nombre:</a>
                        </td>
                        <td>
                            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a>Edad:</a>
                        </td>
                        <td>
                            <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a>Foto:</a>
                        </td>
                        <td  align="center">
                            <asp:Image ID="ImgActual" runat="server" ImageUrl="~/Imagenes/albumDesc.png" height="60" width="60"/><br />
                            <asp:FileUpload ID="ImgCuenta" runat="server"/><br />
                             
                        </td>
                    </tr>
                    <tr style="margin-top: 20px; height: 60px;">
                        <td colspan="3" align="center">
                            <asp:Button ID="btnModificar" runat="server" Text="Modificar Cuenta" OnClick="Button1_Click" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
