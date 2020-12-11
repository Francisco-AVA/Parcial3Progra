<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="RegistroUsuarios.aspx.vb" Inherits="RegistroUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <table class="nav-justified">
        <tr>
            <h1></h1><td colspan="2" style="height: 69px"><h1>Registro de usuarios</h1></td>
        </tr>
        <tr>
            <td style="width: 206px">
                <asp:Label ID="Label1" runat="server" Text="Codigo"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtID" runat="server" Width="280px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 206px">
                <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server" Width="280px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 206px">
                <asp:Label ID="Label3" runat="server" Text="Apellido"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtApellido" runat="server" Width="280px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 206px">
                <asp:Label ID="Label4" runat="server" Text="Edad"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEdad" runat="server" Width="280px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 206px">
                <asp:Label ID="Label5" runat="server" Text="Telefono"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTelefono" runat="server" Width="280px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" />
                <asp:Button ID="btnModificar" runat="server" Text="Modificar" />
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" />
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
                <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" />
                <asp:Label ID="lblResultado" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

