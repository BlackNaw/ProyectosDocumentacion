<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Saludo.aspx.cs" Inherits="SaludoWebForm.Saludo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnSaludar" runat="server" BorderColor="Red" BorderStyle="Dotted" Text="¡Saluda!" OnClick="btnSaludar_Click" />
        <br />
        <asp:Label ID="lblSaludo" runat="server" Text=""></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
