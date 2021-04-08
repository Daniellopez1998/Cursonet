<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EjemplosValidacion.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="StyleSheet1.css"/>
</head>
<body>
    <form id="form1" runat="server">
         
        <div class="Contenedor">
            <div>
                <div class="Labels">
                    <asp:Label ID="Label6"  runat="server" Text="Nombre de usuario:"></asp:Label>
                </div>
                <div class="Textbox">
                    <asp:TextBox cssclass="dos" ID="TextBox1" runat="server" Width="195px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Font-Bold="True" ForeColor="Red">* Debes ingresar el nombre de usuario</asp:RequiredFieldValidator>
            </div>
         </div>

         <div class="Contenedor">
             <div class="Labels">
                 <asp:Label ID="Label1" runat="server" Text="Clave"></asp:Label>
             </div>
             <div class="Textbox">
                 <asp:TextBox cssclass="dos" ID="TextBox5" runat="server" ></asp:TextBox>
             </div>
         </div>

         <div class="Contenedor">
             <div class="Labels">
                 <asp:Label ID="Label4"  runat="server" Text="Repite clave"></asp:Label>
             </div>
             <div class="Textbox">
                 <asp:TextBox cssclass="dos" ID="TextBox4" runat="server" ></asp:TextBox>
                 <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox5" ControlToValidate="TextBox4" ErrorMessage="CompareValidator" Font-Bold="True" ForeColor="Red">* Las claves no coinciden</asp:CompareValidator>
             </div>
          </div>

          <div class="Contenedor">
             <div class="Labels">
                  <asp:Label ID="Label5"  runat="server" Text="Correo electrónico"></asp:Label>
             </div>
             <div class="Textbox">
                 <asp:TextBox cssclass="dos" ID="TextBox6" runat="server"  Width="309px"></asp:TextBox>
                 <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox6" ErrorMessage="RegularExpressionValidator" Font-Bold="True" ForeColor="Red">* El correo electronico no existe</asp:RegularExpressionValidator>
             </div>
           </div>

           <div class="Contenedor">
             <div class="Labels">
               <asp:Label ID="Label2"  runat="server" Text="Apellido:"></asp:Label>
             </div>
             <div class="Textbox">
                 <asp:TextBox cssclass="dos" ID="txtapellido" runat="server" Width="195px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtapellido" Font-Bold="True" ForeColor="Red">* Debes ingresar el apellido</asp:RequiredFieldValidator>
             </div>
            </div>

            <div class="Contenedor">
             <div class="Labels">
               <asp:Label ID="Label3"  runat="server" Text="Nombre:"></asp:Label>
             </div>
             <div class="Textbox">
                 <asp:TextBox cssclass="dos" ID="txtNombre" runat="server" Width="195px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtNombre" Font-Bold="True" ForeColor="Red">* Debes ingresar el Nombre</asp:RequiredFieldValidator>
             </div>
            </div>

            <div class="Contenedor">
             <div class="Labels">
               <asp:Label ID="Label7"  runat="server" Text="Pais de origen:"></asp:Label>
             </div>
             <div class="Textbox">
                 <asp:DropDownList ID="DropDownList1" runat="server">
                     <asp:ListItem>España</asp:ListItem>
                     <asp:ListItem>Italia</asp:ListItem>
                     <asp:ListItem>Belgica</asp:ListItem>
                     <asp:ListItem>Francia</asp:ListItem>
                     <asp:ListItem>Alemania</asp:ListItem>
                     <asp:ListItem>Hungria</asp:ListItem>
                 </asp:DropDownList>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" ControlToValidate="DropDownList1">* Debes ingresar pais de origen></asp:RequiredFieldValidator>
             </div>
            </div>

            
                 <asp:Button ID="Button2" runat="server" Text="Confirmar" OnClick="Button2_Click" />
             
        </div>
    </form>
</body>
</html>
