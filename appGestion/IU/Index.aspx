<%@ Page Title="" Language="C#" MasterPageFile="~/IU/appGesion.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="appGestion.IU.WebForm1" %>
<asp:Content ID="indexContenido" ContentPlaceHolderID="contenido" runat="server">
    

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:proyectoConnection %>" 
        ProviderName="<%$ ConnectionStrings:proyectoConnection.ProviderName %>" 
        DataSourceMode="DataSet"
        UpdateCommand="UPDATE empresas SET nombre=?, ciudad=?, nEmp=? WHERE cif=?;"
        DeleteCommand="Delete from empresas where cif=?;">
        <UpdateParameters>
            <asp:Parameter Name="nombre" Type="String"/>
            <asp:Parameter Name="ciudad" Type="String"/>
            <asp:Parameter Name="nEmp" Type="String"/>
        </UpdateParameters>
 
    </asp:SqlDataSource>

    <asp:GridView ID="GridView1" runat="server" 
        AllowPaging="True" 
        AllowSorting="True" 
        AutoGenerateColumns="False" 
        DataKeyNames="cif" 
        DataSourceID="SqlDataSource1" 
        PageSize="5" >
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:HyperLinkField DataNavigateUrlFields="cif" 
                DataNavigateUrlFormatString="~/IU/Empresas.aspx?cif={0}" 
                DataTextField="cif" HeaderText="CIF" >
            <HeaderStyle CssClass="celdaHeader" />
            <ItemStyle  CssClass="celda" />
            </asp:HyperLinkField>
            <asp:BoundField DataField="nombre" HeaderText="nombre" 
                SortExpression="nombre" >

            <HeaderStyle CssClass="celdaHeader" />
            <ItemStyle CssClass="celda" />
            </asp:BoundField>

            <asp:BoundField DataField="ciudad" HeaderText="ciudad" 
                SortExpression="ciudad" >
            <HeaderStyle CssClass="celdaHeader" />
            <ItemStyle CssClass="celda" />
            </asp:BoundField>
            <asp:BoundField DataField="nEmp" HeaderText="nEmp" SortExpression="nEmp" >
            
            
            <HeaderStyle CssClass="celdaHeader" />
            <ItemStyle CssClass="celda" />
            </asp:BoundField>
            
            
            <asp:TemplateField HeaderText="Tipo">
                <ItemTemplate>
                    <asp:Label runat="server" text='<%# Eval("Tipo") %>'></asp:Label>
                </ItemTemplate>
                <%--<EditItemTemplate>
                    <asp:DropDownList ID="tipo" runat="server" AutoPostBack="True">
                        <asp:ListItem Text="Potenciales" Value="p"></asp:ListItem>
                        <asp:ListItem Text="Firmes" Value="f"></asp:ListItem>
                    </asp:DropDownList>
                </EditItemTemplate>--%>
                <HeaderStyle CssClass="celdaHeader" />
                <ItemStyle CssClass="celda" />
            </asp:TemplateField>
            
            <asp:HyperLinkField DataNavigateUrlFields="cif" 
                DataNavigateUrlFormatString="~/IU/Ofertas.aspx?cif={0}" 
                HeaderText="Añadir oferta" Text="Añadir" />

            <asp:CommandField ShowDeleteButton="True" />
            
        </Columns>

        
    </asp:GridView>

    </asp:Content>
