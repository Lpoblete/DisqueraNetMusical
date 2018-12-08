<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdmProductos.aspx.cs" Inherits="CDMusica.AdmProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table align="center" style="min-height: 480px;">
        <tr style="vertical-align:initial;">
            <td>
                <table>
                    <tr>
                        <td colspan="2" align="center">
                            <a class="titu">Agregar Producto:</a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a>Artista:</a>
                        </td>
                        <td>
                            <asp:TextBox ID="Artista" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a>Album:</a>
                        </td>
                        <td>
                            <asp:TextBox ID="Album" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a>Precio:</a>
                        </td>
                        <td>
                            <asp:TextBox ID="Precio" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a>Genero:</a>
                        </td>
                        <td>
                            <select id="genero" runat="server">
                                <option value="Electronica">Electronica</option>
                                <option value="Jazz">Jazz</option>
                                <option value="Metal">Metal</option>
                                <option value="Pop">Pop</option>
                                <option value="Punk">Punk</option>
                                <option value="Rap">Rap</option>
                            </select>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a>Imagen:</a>
                        </td>
                        <td>
                            <asp:FileUpload ID="Imagen" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3" align="center">
                            <asp:Button ID="Button1" runat="server" Text="Agregar Producto" OnClick="Button1_Click" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>

</asp:Content>
