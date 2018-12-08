<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="CDMusica.Principal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Estilos/estiloPrincipal.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center">
        <tr>
            <td>
                <table>
                    <tr align="center">
                        <td colspan="3">
                            <img src="Imagenes/imagen1.png" height="100" width="700" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3" align="center">
                            <a id="generosRandom" class="titu" runat="server">Discos de [consulta al azar genero]</a>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3" align="center">
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


