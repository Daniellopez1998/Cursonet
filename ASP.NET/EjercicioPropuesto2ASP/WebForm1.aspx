<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EjercicioPropuesto2ASP.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      
        <div>
            <asp:Label ID="Label1" runat="server" Text="¿Cuantas horas tiene un dia?"></asp:Label>
        </div>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" >
            <asp:ListItem>23</asp:ListItem>
            <asp:ListItem>21</asp:ListItem>
            <asp:ListItem Value="24">24</asp:ListItem>
        </asp:RadioButtonList>
         <br />
         <div>
            <asp:Label ID="Label2" runat="server" Text="¿Cuantas minutos tiene una hora?"></asp:Label>
        </div>
        <asp:RadioButtonList ID="RadioButtonList2" runat="server">
            <asp:ListItem>50</asp:ListItem>
            <asp:ListItem>60</asp:ListItem>
            <asp:ListItem>64</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <div>
            <asp:Label ID="Label3" runat="server" Text="¿Cuantas segundos tiene un minuto?"></asp:Label>
        </div>
        <asp:RadioButtonList ID="RadioButtonList3" runat="server">
            <asp:ListItem>50</asp:ListItem>
            <asp:ListItem>60</asp:ListItem>
            <asp:ListItem>62</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        
          <div>
            <asp:Label ID="Label4" runat="server" Text="¿Cuantas dias tiene el mes de enero?"></asp:Label>
        </div>
        <asp:RadioButtonList ID="RadioButtonList4" runat="server" >
            <asp:ListItem>30</asp:ListItem>
            <asp:ListItem>28</asp:ListItem>
            <asp:ListItem Value="24">31</asp:ListItem>
        </asp:RadioButtonList>
      <br />
        <asp:Button ID="Button1" runat="server" Text="Validar respuestas" OnClick="Button1_Click" />
      
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
      
    </form>
</body>
</html>
