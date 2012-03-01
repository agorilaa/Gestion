<%@ Page Title="" Language="C#" MasterPageFile="~/IU/appGesion.Master" AutoEventWireup="true" CodeBehind="Empresas.aspx.cs" Inherits="appGestion.IU.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" runat="server">
    <asp:GridView ID="empresas" runat="server" AllowPaging="True" 
        AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="cif" 
        DataSourceID="empresasSource" PageSize="5">
        <Columns>
            <asp:CommandField ShowEditButton="False" />
            <asp:HyperLinkField DataNavigateUrlFields="cif" 
                DataNavigateUrlFormatString="~/IU/Empresas.aspx?cif={0}" DataTextField="cif" HeaderText="CIF" />
            <asp:BoundField DataField="nombre" HeaderText="nombre" 
                SortExpression="nombre" ReadOnly="true"/>
            <asp:BoundField DataField="ciudad" HeaderText="ciudad" 
                SortExpression="ciudad" />
            <asp:BoundField DataField="nEmp" HeaderText="nEmp" 
                SortExpression="nEmp" />
            <asp:BoundField DataField="tipo" HeaderText="tipo" SortExpression="tipo" />
            <asp:CommandField ShowDeleteButton="False" />
        </Columns>
        <SelectedRowStyle BackColor="#339966" />
    </asp:GridView>
    <asp:SqlDataSource ID="empresasSource" runat="server" 
        ConnectionString="<%$ ConnectionStrings:proyectoConnection %>" 
        DeleteCommand="delete from empresas where cif=?;" 
        ProviderName="<%$ ConnectionStrings:proyectoConnection.ProviderName %>" 
        SelectCommand="select * from empresas;" 
        UpdateCommand="update empresas set nombre=?, ciudad=?, nEmp=?, tipo=? where cif=?;">
    </asp:SqlDataSource>
    
    <asp:GridView ID="detallesempresa" runat="server" AllowPaging="True" 
        AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="cif" 
        DataSourceID="detallesEmpresaSource" PageSize="5">
    
        <Columns>
            <asp:BoundField DataField="cif" HeaderText="cif" SortExpression="cif" />
            <asp:HyperLinkField DataNavigateUrlFields="codO,cif" 
                DataNavigateUrlFormatString="~/IU/Empresas.aspx?codO={0}&cif={1}" DataTextField="codO" HeaderText="Oferta" />
            <asp:BoundField DataField="fecha" HeaderText="fecha" SortExpression="fecha" HtmlEncode="False" DataFormatString="{00:M/dd/yyyy}" />
            <asp:BoundField DataField="coste" HeaderText="coste" SortExpression="coste" />
            <asp:BoundField DataField="dni" HeaderText="dni" ReadOnly="True" 
                SortExpression="dni" />
        </Columns>

    </asp:GridView>

    <asp:Label ID="nombre" runat="server" Text=""></asp:Label>
    <asp:SqlDataSource ID="detallesEmpresaSource" runat="server" 
        ConnectionString="<%$ ConnectionStrings:proyectoConnection %>" 
        ProviderName="<%$ ConnectionStrings:proyectoConnection.ProviderName %>" >
    </asp:SqlDataSource>

    <asp:DetailsView ID="detallesOferta" runat="server" Height="50px" Width="125px" 
        AutoGenerateRows="False" DataSourceID="detallesOfertaSource">
        <Fields>
            <asp:BoundField DataField="codO" HeaderText="codO" InsertVisible="False" 
                SortExpression="codO" />
            <asp:BoundField DataField="nombreO" HeaderText="nombre" 
                SortExpression="nombre" />
            <asp:BoundField DataField="tipoO" HeaderText="tipo" SortExpression="tipo" />
        </Fields>
    </asp:DetailsView>

   

    <asp:SqlDataSource ID="detallesOfertaSource" runat="server" 
        ConnectionString="<%$ ConnectionStrings:proyectoConnection %>" 
        ProviderName="<%$ ConnectionStrings:proyectoConnection.ProviderName %>" 
        SelectCommand=""></asp:SqlDataSource>

   

</asp:Content>
