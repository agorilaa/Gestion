<%@ Page Title="" Language="C#" MasterPageFile="~/IU/appGesion.Master" AutoEventWireup="true" CodeBehind="NuevaEmpresa.aspx.cs" Inherits="appGestion.IU.WebForm3" %>
<asp:Content ID="nuevaEmpresa" ContentPlaceHolderID="contenido" runat="server">
   <div id=nEmpresa>
    <h2>NUEVA EMPRESA</h2>
        <p class="grid_8"><asp:Label ID="cif" runat="server" Text="CIF" CssClass="grid_1"></asp:Label>
        <asp:TextBox ID="cifBox" runat="server" CssClass="grid_2"></asp:TextBox>
        <asp:RegularExpressionValidator ID="validaCifBox" runat="server" 
                ErrorMessage="Tiene que introducir un CIF válido del tipo A18767365" 
                ControlToValidate="cifBox" 
                CssClass="grid_4" 
                ValidationExpression="[A-Z]{1}[0-9]{8}" 
                Display="Dynamic" 
                Font-Size="Small"></asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ID="validaCifBoxReq" runat="server" 
                ErrorMessage="*" 
                ControlToValidate="cifBox" 
                CssClass="grid_4" 
                Display="Dynamic" 
                Font-Size="Medium"></asp:RequiredFieldValidator>
        </p><br />

        <p class="grid_8"><asp:Label ID="nomEmp" runat="server" Text="Nombre" CssClass="grid_1"></asp:Label>
        <asp:TextBox ID="nomEmpBox" runat="server" CssClass="grid_2"></asp:TextBox>
        <asp:RequiredFieldValidator ID="validaNomEmpReq" runat="server" 
                ErrorMessage="*" 
                ControlToValidate="nomEmpBox" 
                CssClass="grid_4"></asp:RequiredFieldValidator>
        </p><br />

        <p class="grid_8"><asp:Label ID="ciudad" runat="server" Text="Ciudad" CssClass="grid_1"></asp:Label>
        <asp:TextBox ID="ciudadBox" runat="server" CssClass="grid_2"></asp:TextBox>
            <%--<asp:RegularExpressionValidator ID="validaCiudad" runat="server" 
            ErrorMessage="Tiene que ser una ciudad válida"
            CssClass="grid_4" 
            ValidationExpression="[A-Za-z]{20}" 
            Font-Size="Small" 
            ControlToValidate="ciudadBox" 
            Display="Dynamic"></asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator ID="validaCiudadReq" runat="server" 
            ErrorMessage="*" 
            Display="Dynamic" 
            CssClass="grid_4" 
            ControlToValidate="ciudadBox"></asp:RequiredFieldValidator>--%>
        </p><br />

        <p class="grid_4"><asp:Label ID="numEmp" runat="server" Text="Nº Empleados" CssClass="grid_2"></asp:Label>
        <asp:TextBox ID="numEmpBox" runat="server" CssClass="grid_1"></asp:TextBox>
            <%--<asp:RegularExpressionValidator ID="validaNumEmp" runat="server" 
            ErrorMessage="*" 
            ControlToValidate="numEmpBox"
            CssClass="grid_4"
            ValidationExpression="[0-9]{5}"></asp:RegularExpressionValidator>--%>
        </p><br />

        <p class="grid_4"><asp:Label ID="tipo" runat="server" Text="Tipo" CssClass="grid_1"></asp:Label>
        <asp:DropDownList ID="tipoLista" runat="server" CssClass="grid_2">
            <asp:ListItem Text="Con ofertas" Value="f"></asp:ListItem>
            <asp:ListItem Text="Sin ofertas" Value="p"></asp:ListItem>
        </asp:DropDownList>
        </p><br />

        <p class="grid_4"><asp:Button ID="new" runat="server" Text="Añadir" onclick="Button1_Click"  CssClass="grid_1"/>
        <asp:Label ID="Label1" runat="server" Text="Label" CssClass="grid_2"></asp:Label></p>
    </div>
</asp:Content>
