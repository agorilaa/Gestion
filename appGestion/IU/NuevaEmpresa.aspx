<%@ Page Title="" Language="C#" MasterPageFile="~/IU/appGesion.Master" AutoEventWireup="true" CodeBehind="NuevaEmpresa.aspx.cs" Inherits="appGestion.IU.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" runat="server">
<h2>NUEVA EMPRESA</h2>
 <asp:Label ID="cif" runat="server" Text="CIF"></asp:Label>
    <asp:TextBox ID="cifBox" runat="server"></asp:TextBox>
    <asp:Label ID="nomEmp" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="nomEmpBox" runat="server"></asp:TextBox>
    <asp:Label ID="ciudad" runat="server" Text="Ciudad"></asp:Label>
    <asp:TextBox ID="ciudadBox" runat="server"></asp:TextBox>
    <asp:Label ID="numEmp" runat="server" Text="Nº Empleados"></asp:Label>
    <asp:TextBox ID="numEmpBox" runat="server"></asp:TextBox>
    <asp:Label ID="tipo" runat="server" Text="Tipo"></asp:Label>
    <asp:DropDownList ID="tipoLista" runat="server">
        <asp:ListItem Text="Con ofertas" Value="f"></asp:ListItem>
        <asp:ListItem Text="Sin ofertas" Value="p"></asp:ListItem>
    </asp:DropDownList>
    <asp:Button ID="new" runat="server" Text="Añadir" onclick="Button1_Click" />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</asp:Content>
