<%@ Page Title="" Language="C#" MasterPageFile="~/IU/appGesion.Master" AutoEventWireup="true" CodeBehind="Buscar.aspx.cs" Inherits="appGestion.IU.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" runat="server">
    <asp:Label ID="prueba" runat="server" Text="Label"></asp:Label>
    <asp:Label ID="numero" runat="server" Text=""></asp:Label>
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
    <asp:DropDownList ID="tipoE" runat="server">
        <asp:ListItem Value="%">Seleccione...</asp:ListItem>
        <asp:ListItem Text="Firmes" Value="f"></asp:ListItem>
        <asp:ListItem Text="Potenciales" Value="p"></asp:ListItem>
    </asp:DropDownList>
    

<h2>Ofertas</h2>

    <asp:Label ID="codigo" runat="server" Text="Código"></asp:Label>
    <asp:TextBox ID="tbCodigo" runat="server"></asp:TextBox>

    <asp:Label ID="nombre" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="tbNombre" runat="server"></asp:TextBox>

    <asp:Label ID="desc" runat="server" Text="Descripción"></asp:Label>
    <asp:TextBox ID="tbDesc" runat="server"></asp:TextBox>

    <asp:Label ID="tipoOfer" runat="server" Text="Tipo"></asp:Label>
    <asp:TextBox ID="tbTipo" runat="server"></asp:TextBox>

    <asp:Label ID="ambito" runat="server" Text="Ámbito"></asp:Label>
    <asp:DropDownList ID="ambitoList" runat="server">
        <asp:ListItem Value="%">Seleccione...</asp:ListItem>
        <asp:ListItem Value="L">Local</asp:ListItem>
        <asp:ListItem Value="P">Provincial</asp:ListItem>
        <asp:ListItem Value="E">Estatal</asp:ListItem>
    </asp:DropDownList>

    <asp:Label ID="estado" runat="server" Text="Estado"></asp:Label>
    <asp:DropDownList ID="estadoList" runat="server">
        <asp:ListItem Value="%">Seleccione...</asp:ListItem>
        <asp:ListItem Value="A">Alta</asp:ListItem>
        <asp:ListItem Value="P">Pendiente</asp:ListItem>
    </asp:DropDownList>

    <asp:Label ID="coste" runat="server" Text="Coste"></asp:Label>
    <asp:TextBox ID="tbCoste" runat="server"></asp:TextBox>

    <asp:Button ID="buscar" runat="server" Text="Buscar" onclick="buscar_Click" />
    
    
    <asp:GridView ID="buscarRes" runat="server" AllowPaging="True" 
        AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="cif" 
        DataSourceID="buscarSql" PageSize="5" Font-Size="small">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="cif" 
                DataNavigateUrlFormatString="~/IU/Empresas.aspx?cif={0}" 
                DataTextField="cif" HeaderText="CIF" >
            <HeaderStyle CssClass="celdaHeader" />
            <ItemStyle CssClass="celda" />
            </asp:HyperLinkField>
            <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" 
                ReadOnly="true">
            <HeaderStyle CssClass="celdaHeader" />
            <ItemStyle CssClass="celda" />
            </asp:BoundField>
            <asp:BoundField DataField="ciudad" HeaderText="Ciudad" SortExpression="ciudad" >
            <HeaderStyle CssClass="celdaHeader" />
            <ItemStyle CssClass="celda" />
            </asp:BoundField>
            <asp:BoundField DataField="nEmp" HeaderText="Plantilla" SortExpression="nEmp" >
            <HeaderStyle CssClass="celdaHeader" />
            <ItemStyle CssClass="celda" />
            </asp:BoundField>
            <asp:BoundField DataField="tipo" HeaderText="Tipo" SortExpression="tipo" >
            <HeaderStyle CssClass="celdaHeader" />
            <ItemStyle CssClass="celda" />
            </asp:BoundField>
            <asp:BoundField DataField="codO" HeaderText="Código" SortExpression="codO" >
            <HeaderStyle CssClass="celdaHeader" />
            <ItemStyle CssClass="celda" />
            </asp:BoundField>
            <asp:BoundField DataField="nombreO" HeaderText="Nombre Of" 
                SortExpression="nombre" >
            <HeaderStyle CssClass="celdaHeader" />
            <ItemStyle CssClass="celda" />
            </asp:BoundField>
            <asp:BoundField DataField="descr" HeaderText="Descripción" 
                SortExpression="descr" >
            <HeaderStyle CssClass="celdaHeader" />
            <ItemStyle CssClass="celda" />
            </asp:BoundField>
            <asp:BoundField DataField="tipoO" HeaderText="Tipo Of" 
                SortExpression="tipoO" >
            <HeaderStyle CssClass="celdaHeader" />
            <ItemStyle CssClass="celda" />
            </asp:BoundField>
           <%-- <asp:BoundField DataField="ambito" HeaderText="Ámbito" SortExpression="ambito" >
            <HeaderStyle CssClass="celdaHeader" />
            <ItemStyle CssClass="celda" />
            </asp:BoundField>
            <asp:BoundField DataField="estado" HeaderText="Estado" SortExpression="estado" >
            <HeaderStyle CssClass="celdaHeader" />
            <ItemStyle CssClass="celda" />
            </asp:BoundField>
            <asp:BoundField DataField="coste" HeaderText="Coste" SortExpression="coste" >
            <HeaderStyle CssClass="celdaHeader" />
            <ItemStyle CssClass="celda" />
            </asp:BoundField>--%>
        </Columns>
        <SelectedRowStyle BackColor="#339966" />
    </asp:GridView>
    
    <asp:SqlDataSource ID="buscarSql" runat="server" 
        ConnectionString="<%$ ConnectionStrings:proyectoConnection %>" 
        ProviderName="<%$ ConnectionStrings:proyectoConnection.ProviderName %>" 
        ></asp:SqlDataSource>
</asp:Content>
