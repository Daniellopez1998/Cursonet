<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASP.NET.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="StyleSheet1.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ingrese primer valor:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            
        </div>
        <asp:Label ID="Label2" runat="server" Text="Ingrese segundo valor:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <p>
            <asp:RadioButton ID="RadioButton1" runat="server"  Text="Sumar" />
        </p>
        <p>
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Restar" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Resultado" OnClick="Button1_Click1" />
        </p>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
            <asp:Label ID="Label4" runat="server" Text="Ingrese primer valor:"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            
        <br />
        <asp:Label ID="Label5" runat="server" Text="Ingrese segundo valor:"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Sumar</asp:ListItem>
            <asp:ListItem>Restar</asp:ListItem>
            <asp:ListItem>Multiplicar</asp:ListItem>
            <asp:ListItem>Dividir</asp:ListItem>
        </asp:DropDownList>
        <br />
            <asp:Button ID="Button2" runat="server" Text="Resultado" OnClick="Button2_Click1" />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
            <asp:Label ID="Label7" runat="server" Text="Ingrese primer valor:"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            
        <br />
        <asp:Label ID="Label8" runat="server" Text="Ingrese segundo valor:"></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            
        <br />
        <asp:ListBox ID="ListBox1" runat="server">
            <asp:ListItem>Sumar</asp:ListItem>
            <asp:ListItem>Restar</asp:ListItem>
            <asp:ListItem>Producto</asp:ListItem>
            <asp:ListItem>Cociente</asp:ListItem>
        </asp:ListBox>
        <br />
            <asp:Button ID="Button3" runat="server" Text="Resultado" OnClick="Button3_Click1" />
        <br />
        <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
        <br />
            
    </form>
</body>
</html>
