<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CarritoCompras.aspx.cs" Inherits="CDMusica.CarritoCompras" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Estilos/estiloCarritoCompras.css" rel="stylesheet" type="text/css" />
    <script src="JQuery/jquery.js" type="text/javascript"></script>
    <script src="JQuery/script.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center">
        <tr>
            <td>
                <table>
                    <tr>
                        <td colspan="4" align="center">
                            <a class="titu">Carrito de Compras</a>
                        </td>
                    </tr>
                    <tr bgcolor="orange" border="1">
                        <td>Album
                        </td>
                        <td>Precio unitario
                        </td>
                    </tr>

                    <%
                        try
                        {
                            if (detallesVentas.Rows.Count > 0)
                            {
                                foreach (System.Data.DataRow dr in detallesVentas.Rows)
                                {
                    %>
                    <tr bgcolor="orange" border="1">
                        <td>
                            <%=dr["Album"].ToString() %>
                        </td>
                        <td>
                            <%=dr["Sub_total"].ToString() %>
                        </td>
                    </tr>
                    <%
                                }
                            }
                        }
                        catch (Exception)
                        {

                        }
                    %>
                    <tr bgcolor="cyan" border="1">
                        <td colspan="3" align="center">Valor total: <a id="montoFinal" runat="server">0</a>
                        </td>
                    </tr>
                    <tr bgcolor="cyan" border="1">
                        <td colspan="3" align="center">
                            <asp:Button ID="Button1" runat="server" Text="Finalizar Compra" OnClick="Button1_Click" />
                        </td>
                    </tr>

                </table>
            </td>
        </tr>
    </table>
</asp:Content>
