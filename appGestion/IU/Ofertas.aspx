<%@ Page Title="" Language="C#" MasterPageFile="~/IU/appGesion.Master" AutoEventWireup="true" CodeBehind="Ofertas.aspx.cs" Inherits="appGestion.IU.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" runat="server">
    <asp:GridView ID="ofertasRes" runat="server" AllowPaging="True" 
        AllowSorting="True" AutoGenerateColumns="False" DataSourceID="ofertasSql" DataKeyNames="codO">
        <Columns>
            <asp:BoundField DataField="codO" HeaderText="Código" SortExpression="codO" />
            <%--<asp:HyperLinkField DataNavigateUrlFields="cif" 
                DataNavigateUrlFormatString="~/IU/Empresas.aspx?cif={0}" DataTextField="cif" HeaderText="CIF" />--%>
            <asp:BoundField DataField="nombreO" HeaderText="Nombre Oferta" SortExpression="nombre" />
            <asp:BoundField DataField="descr" HeaderText="Descripcion" SortExpression="descr" />
            <asp:BoundField DataField="tipoO" HeaderText="Tipo Oferta" SortExpression="tipoO" />
            <asp:BoundField DataField="ambito" HeaderText="Ámbito" SortExpression="ambito" />
            <asp:BoundField DataField="estado" HeaderText="Estado" SortExpression="estado" />
            <asp:BoundField DataField="coste" HeaderText="Coste" SortExpression="coste" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBoxOf" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
  
        </Columns>
    </asp:GridView>
    <asp:Button ID="añadir" runat="server" Text="Añadir" onclick="añadir_Click" />
    <asp:Label ID="mens" runat="server" Text=""></asp:Label>
    <asp:SqlDataSource ID="ofertasSql" runat="server" 
        ConnectionString="<%$ ConnectionStrings:proyectoConnection %>" 
        ProviderName="<%$ ConnectionStrings:proyectoConnection.ProviderName %>" >
        </asp:SqlDataSource>
</asp:Content>
