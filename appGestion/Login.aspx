<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="appGestion.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Aplicación de gestión</title>
    <meta content="utf-8" />
	<link rel="stylesheet" href="IU/css/reset.css" />
	<link rel="stylesheet" href="IU/css/960.css" />
	<link rel="stylesheet" href="IU/css/text.css" />
	<link rel="stylesheet" href="IU/css/styles.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="wrap container_12">
    
	<header class="grid_12">
		<h1 class="grid_9">Nombre APP</h1>
	</header>
    <div class="main grid_12">
        <div class="content grid_9 alpha">
            <asp:Label ID="usuario" runat="server" Text="DNI"></asp:Label>
            <asp:TextBox ID="tbUsuario" runat="server"></asp:TextBox>
            <asp:Label ID="contrasena" runat="server" Text="Contraseña"></asp:Label>
            <asp:TextBox ID="tbPassw" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Label ID="error" runat="server" Text=""></asp:Label>
            <asp:Button ID="entrar" runat="server" Text="Entrar" onclick="Entrar_Click" />
        </div>
    </div>
    </div>
    </form>
</body>
</html>
