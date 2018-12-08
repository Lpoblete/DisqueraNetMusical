<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Contactanos.aspx.cs" Inherits="CDMusica.Contactanos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Estilos/estiloContactanos.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

           <table align="center">
                <tr>
                    <td colspan="2" align="center">
                        <a class="titu">Contactanos</a>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <a>Tipo Consulta:</a>
                        <select id="slctConsulta" runat="server">
                            <option value="Seleccione">Seleccione:</option>
                            <option value="Sugerencia">Sugerencia</option>
                            <option value="Reclamo">Reclamo</option>
                            <option value="Consulta_General">Consulta General</option>
                            <option value="Otro">Otro</option>
                        </select>
                    </td>
                </tr>
               <tr>
                   <td>
                       <a>Ingrese su Email:</a>
                   </td>
                   <td>
                       
                       <input type="email" id="txtEmail" runat="server"/>
                   </td>
               </tr>
                <tr>
                    <td colspan="2">
                        <a>Area de Consulta:</a>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <textarea id="txtAreaComentario" rows="10" cols="50" runat="server"></textarea>
                    </td>
                </tr>
               <tr style="height: 55px">
                   <td align="center"><asp:Button ID="btnEnviar" runat="server" Text="Enviar"  style="width: 85px" OnClick="btnEnviar_Click" /></td>
                   <td align="center"><asp:Button ID="btnLimpiar" runat="server" Text="Limpiar"  style="width: 85px" OnClick="btnLimpiar_Click"/></td>
               </tr>
            </table>

    
   
</asp:Content>
