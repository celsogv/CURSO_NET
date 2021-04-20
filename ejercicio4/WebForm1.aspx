<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ejercicio4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ingrese nombre de usuario"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Debe ingresar el nombre de usuario">Debe ingresar el nombre de usuario</asp:RequiredFieldValidator>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Height="26px" OnClick="Button1_Click" style="margin-bottom: 0px" Text="Button" />
        </p>
    </form>
</body>
</html>
