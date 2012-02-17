<%@ Page Title="" Language="C#" MasterPageFile="~/IU/appGesion.Master" AutoEventWireup="true" CodeBehind="Buscar.aspx.cs" Inherits="appGestion.IU.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" runat="server">
<h2>Empresas</h2>
    <asp:Label ID="cif" runat="server" Text="CIF"></asp:Label>
    <asp:TextBox ID="cifBox" runat="server"></asp:TextBox>
    <asp:Label ID="nomEmp" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="nomEmpBox" runat="server"></asp:TextBox>
    <asp:Label ID="ciudad" runat="server" Text="Ciudad"></asp:Label>
    <asp:TextBox ID="ciudadBox" runat="server"></asp:TextBox>
    <asp:Label ID="numEmp" runat="server" Text="Nº Empleados"></asp:Label>
    <asp:TextBox ID="numEmpBox" runat="server"></asp:TextBox>
    <asp:Label ID="tipo" runat="server" Text="Tipo"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem Text="Con ofertas" Value="f"></asp:ListItem>
        <asp:ListItem Text="Sin ofertas" Value="p"></asp:ListItem>
    </asp:DropDownList>
<h2>Ofertas</h2>
</asp:Content>
