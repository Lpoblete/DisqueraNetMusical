<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="VerBoletas.aspx.cs" Inherits="CDMusica.VerBoletas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="min-height: 480px;">
        <table align="center">
            <tr>
                <td colspan="5" align="center">
                    <a class="titu">Boletas</a>
                </td>
            </tr>
            <tr bgcolor="orange" border="1">
                <td>ID
                </td>
                <td>Fecha
                </td>
                <td>Cliente_correo
                </td>
                <td>Total_venta
                </td>
            </tr>

            <%
                try
                {
                    if (ventas.Rows.Count > 0)
                    {
                        foreach (System.Data.DataRow dr in ventas.Rows)
                        {
            %>
            <tr bgcolor="cyan" border="1">
                <td>
                    <%=dr["ID_venta"].ToString() %>
                </td>
                <td>
                    <%=dr["Fecha"].ToString() %>
                </td>
                <td>
                    <%=dr["Cliente_correo"].ToString() %>
                </td>
                <td>
                    <%=dr["Total_venta"].ToString() %>
                </td>
                <td>
                    <a href="<%=dr["Comprobante"].ToString() %>" target="_blank">Ver comprobante</a>
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
        </table>
    </div>
</asp:Content>
