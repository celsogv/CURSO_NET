<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ejercicio2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="estilos.css">
    <title></title>
</head>
<body style="height: 330px">
    <form id="form1" runat="server">
        
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Ingrese primer valor"></asp:Label>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <asp:Label ID="Label2" runat="server" Text="Ingrese segundo valor"></asp:Label>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </p>
        <asp:RadioButton ID="RadioButton1" runat="server" text="sumar" OnCheckedChanged="RadioButton1_CheckedChanged" />
        <p>
            <asp:RadioButton ID="RadioButton2" runat="server" text="restar" OnCheckedChanged="RadioButton2_CheckedChanged"/>
        </p>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" />
        <p>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </p>



        



    </form>
</body>
</html>
