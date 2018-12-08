<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Discos.aspx.cs" Inherits="CDMusica.Artistas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Estilos/estiloDiscos.css" rel="stylesheet" type="text/css" />
    <script src="JQuery/jquery.js" type="text/javascript"></script>
    <script src="JQuery/script.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table align="center">
        <tr>
            <td>
                <table>
                    <tr>
                        <td colspan="3" align="center">
                            <a class="titu">Discos</a>
                        </td>
                    </tr>
                    <tr align="center">
                        <td>Buscar por nombre:
                            <input id="nomb" type="text" runat="server" />
                            <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click" />
                        </td>
                    </tr>
                    <tr align="center">
                        <td>Buscar por artista:
                            <input id="arti" type="text" runat="server" />
                            <asp:Button ID="Button2" runat="server" Text="Buscar" OnClick="Button2_Click" />
                        </td>
                    </tr>
                    <tr align="center">
                        <td>Buscar por genero:
                            <input id="gene" type="text" runat="server" />
                            <asp:Button ID="Button3" runat="server" Text="Buscar" OnClick="Button3_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            <div class="scrollMenu">
                                <table>
                                    <tr>
                                        <%
                                            try
                                            {
                                                int i = 0;

                                                if (productos.Rows.Count > 0)
                                                {
                                                    foreach (System.Data.DataRow dr in productos.Rows)
                                                    {
                                                        i++;

                                                        if (i <= 2)
                                                        {
                                        %>
                                        <td align="center">
                                            <img src="<%=dr["Imagen"].ToString() %>" height="200" width="200" />
                                            <br />
                                            <a><%=dr["Genero"].ToString() %></a>
                                            <br />
                                            <a><%=dr["Artista"].ToString() %></a>
                                            <br />
                                            <a><%=dr["Album"].ToString() %></a>
                                            <br />
                                            <a><%=dr["Precio"].ToString() %></a>
                                            <br />
                                            <a href="CarritoCompras.aspx?idPro=<%=dr["ID_producto"].ToString() %>">Agregar <%=dr["Album"].ToString() %> al carrito</a>
                                        </td>
                                        <%
                                            }
                                            else
                                            {
                                        %>
                                        <td align="center">
                                            <img src="<%=dr["Imagen"].ToString() %>" height="200" width="200" />
                                            <br />
                                            <a><%=dr["Genero"].ToString() %></a>
                                            <br />
                                            <a><%=dr["Artista"].ToString() %></a>
                                            <br />
                                            <a><%=dr["Album"].ToString() %></a>
                                            <br />
                                            <a><%=dr["Precio"].ToString() %></a>
                                            <br />
                                            <a href="CarritoCompras.aspx?idPro=<%=dr["ID_producto"].ToString() %>">Agregar <%=dr["Album"].ToString() %> al carrito</a>
                                        </td>
                                        <%
                                        %>
                                        <tr>
                                            <td></td>
                                        </tr>
                                        <%
                                                            i = 0;
                                                        }
                                                    }
                                                }
                                            }
                                            catch
                                            {

                                            }
                                        %>
                                    </tr>
                                </table>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3" align="center">
                            <img src="Imagenes/imagen2.png" height="100" width="700" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>

</asp:Content>
