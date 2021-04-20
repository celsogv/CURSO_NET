<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ejercicio_de_validacion.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="estilos.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="contenedor">
           <div id="izquierda">
               <p>
                   <asp:Label ID="Label1" runat="server" Text="Nombre de usuario"></asp:Label>
               </p>
               <p>
                   <asp:Label ID="Label2" runat="server" Text="Clave"></asp:Label>
               </p>
               <p>
                   <asp:Label ID="Label3" runat="server" Text="repita la clave"></asp:Label>
               </p>
               <p>
                   <asp:Label ID="Label4" runat="server" Text="Correo electronico"></asp:Label>
               </p>
               <p>
                   <asp:Label ID="Label5" runat="server" Text="Apellido"></asp:Label>
               </p>
               <p>
                   <asp:Label ID="Label6" runat="server" Text="Nombre"></asp:Label>
               </p>
               <p>
                   <asp:Label ID="Label7" runat="server" Text="Pais de origen"></asp:Label>
               </p>
               <p>
                   <asp:Label ID="Label8" runat="server" Text="Sexo"></asp:Label>
               </p>
               <p>
                   <asp:Label ID="Label9" runat="server" Text="Fecha de nacimiento"></asp:Label>
               </p>
               <p>
                   <asp:Label ID="Label10" runat="server" Text="(dd/mm/aaaa)"></asp:Label>
               </p>
               <p>
                   &nbsp;</p>
               <p>
                   &nbsp;</p>
               <p>
                   <asp:Label ID="Label11" runat="server" Text="comentarios"></asp:Label>
               </p>
               <p>&nbsp;</p>
               <p>&nbsp;</p>
               <p>&nbsp;</p>
               <p>&nbsp;</p>
               <p>&nbsp;</p>
               <p>&nbsp;</p>
               <p>&nbsp;</p>
               <p>
                   <asp:Label ID="Label12" runat="server" Text="Acepto los terminos"></asp:Label>
               </p>
               <p>
                   <asp:Label ID="Label13" runat="server" Text="y condiciones"></asp:Label>
               </p>
           </div>
            <asp:TextBox ID="TextBox1" runat="server" Width="289px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="RequiredFieldValidator">Debe ingresar el nombre de usuario</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="RequiredFieldValidator">Debe ingresar la clave</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:TextBox ID="TextBox3" runat="server" CausesValidation="True"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="RequiredFieldValidator">Debe repetir la clave</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="RequiredFieldValidator">Debe ingresar el correo</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="RequiredFieldValidator">Debe ingresar el apellido</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox8" ErrorMessage="RequiredFieldValidator">Debe ingresar el nombre</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" Width="193px">
                <asp:ListItem>España</asp:ListItem>
                <asp:ListItem>Alemania</asp:ListItem>
                <asp:ListItem>Inghlaterra</asp:ListItem>
                <asp:ListItem>Francia</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="DropDownList1" ErrorMessage="RequiredFieldValidator">Debe ingresar el pais</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:RadioButton ID="RadioButton1" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Hombre" GroupName="sexo" />
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Mujer" GroupName="sexo"/>
            <br />
            <br />
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox6" ErrorMessage="RequiredFieldValidator">Debe ingresar la fecha de nacimiento</asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBox7" ErrorMessage="RequiredFieldValidator">Debe ingresar comentarios</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:TextBox ID="TextBox7" runat="server" Height="371px" Width="704px" OnTextChanged="TextBox7_TextChanged"></asp:TextBox>
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Acepto"/>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Aceptar" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
