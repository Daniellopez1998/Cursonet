<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GestionClientes.aspx.cs" Inherits="ASPMacroEjercicioJueves.GestionClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>GESTIÓN DE CLIENTES</h1>

    <!-- ******Altas****** -->
    <div class="Principales">
        <div>
            <div class="titulares">
                <h2>Altas de clientes</h2>
            </div>
            <div class="labels">
                <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>
            </div>

            <div class="txtbox">
                <asp:TextBox ID="TxtIdA" runat="server" CssClass="txt"></asp:TextBox>
                <asp:RequiredFieldValidator ValidationGroup="1" ID="IdA" runat="server" ErrorMessage="*" Font-Bold="True" ControlToValidate="TxtIdA" ValidationExpression="^\d+$" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>

            <div class="labels">
                <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
            </div>

            <div class="txtbox">
                <asp:TextBox ID="TxtNombreA" runat="server" CssClass="txt"></asp:TextBox>
                <asp:RequiredFieldValidator ValidationGroup="1" ID="NombreA" runat="server" ErrorMessage="*" Font-Bold="True" ControlToValidate="TxtNombreA" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>

            <div class="labels">
                <asp:Label ID="Label3" runat="server" Text="Apellido 1"></asp:Label>
            </div>

            <div class="txtbox">
                <asp:TextBox ID="TxtApellido1A" runat="server" CssClass="txt"></asp:TextBox>
                <asp:RequiredFieldValidator ValidationGroup="1" ID="Apellido1A" runat="server" ErrorMessage="*" Font-Bold="True" ControlToValidate="TxtApellido1A" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>

            <div class="labels">
                <asp:Label ID="Label4" runat="server" Text="Apellido 2"></asp:Label>
            </div>

            <div class="txtbox">
                <asp:TextBox ID="TxtApellido2A" runat="server" CssClass="txt"></asp:TextBox>
                <asp:RequiredFieldValidator ValidationGroup="1" ID="Apellido2A" runat="server" ErrorMessage="*" Font-Bold="True" ControlToValidate="TxtApellido2A" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>

            <div class="labels">
                <asp:Label ID="Label5" runat="server" Text="Ciudad"></asp:Label>
            </div>

            <div class="txtbox">
                <asp:TextBox ID="TxtCiudadA" runat="server" CssClass="txt"></asp:TextBox>
                <asp:RequiredFieldValidator ValidationGroup="1" ID="CiudadA" runat="server" ErrorMessage="*" Font-Bold="True" ControlToValidate="TxtCiudadA" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>

            <div class="labels">
                <asp:Label ID="Label6" runat="server" Text="Categoria"></asp:Label>
            </div>

            <div class="txtbox">
                <asp:TextBox ID="TxtCategoriaA" runat="server" CssClass="txt"></asp:TextBox>
                <asp:RequiredFieldValidator ValidationGroup="1" ID="CategoriaA" runat="server" ErrorMessage="*" Font-Bold="True" ControlToValidate="TxtCategoriaA" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <asp:Button ValidationGroup="1" ID="Button1" runat="server" Text="Añadir" OnClick="Button1_Click" /><asp:Label ID="Label14" runat="server" Text=""></asp:Label>   
        </div>
    </div>

    <!-- ******Modificaciones****** -->
    <div class="Principales">
        <div>
            <div class="titulares">
                <h2>Modificaciones de clientes</h2>
            </div>
            <div class="labels">
                <asp:Label ID="Label7" runat="server" Text="Id"></asp:Label>
            </div>

            <div class="txtbox">
                <asp:DropDownList ID="ddlIdM" runat="server" DataSourceID="SqlDataSource1" DataTextField="id" DataValueField="id"></asp:DropDownList>
                <asp:Button ValidationGroup="2" ID="Button3" runat="server" Text="Buscar" OnClick="Button3_Click" />
            </div>

            <div class="labels">
                <asp:Label ID="Label8" runat="server" Text="Nombre"></asp:Label>
            </div>

            <div class="txtbox">
                <asp:TextBox ID="TxtNombreM" runat="server" CssClass="txt"></asp:TextBox>
                <asp:RegularExpressionValidator ValidationGroup="2" ID="NombreM" runat="server" ErrorMessage="*" Font-Bold="True" ControlToValidate="TxtNombreM" ForeColor="Red"></asp:RegularExpressionValidator>
            </div>

            <div class="labels">
                <asp:Label ID="Label9" runat="server" Text="Apellido 1"></asp:Label>
            </div>

            <div class="txtbox">
                <asp:TextBox ID="TxtApellido1M" runat="server" CssClass="txt"></asp:TextBox>
                <asp:RegularExpressionValidator ValidationGroup="2" ID="Apellido1M" runat="server" ErrorMessage="*" Font-Bold="True" ControlToValidate="TxtApellido1M" ForeColor="Red"></asp:RegularExpressionValidator>
            </div>

            <div class="labels">
                <asp:Label ID="Label10" runat="server" Text="Apellido 2"></asp:Label>
            </div>

            <div class="txtbox">
                <asp:TextBox ID="TxtApellido2M" runat="server" CssClass="txt"></asp:TextBox>
                <asp:RegularExpressionValidator ValidationGroup="2" ID="Apellido2M" runat="server" ErrorMessage="*" Font-Bold="True" ControlToValidate="TxtApellido2M" ForeColor="Red"></asp:RegularExpressionValidator>
            </div>

            <div class="labels">
                <asp:Label ID="Label11" runat="server" Text="Ciudad"></asp:Label>
            </div>

            <div class="txtbox">
                <asp:TextBox ID="TxtCiudadM" runat="server" CssClass="txt"></asp:TextBox>
                <asp:RegularExpressionValidator ValidationGroup="2" ID="CiudadM" runat="server" ErrorMessage="*" Font-Bold="True" ControlToValidate="TxtCiudadM" ForeColor="Red"></asp:RegularExpressionValidator>
            </div>

            <div class="labels">
                <asp:Label ID="Label12" runat="server" Text="Categoria"></asp:Label>
            </div>

            <div class="txtbox">
                <asp:TextBox ID="TxtCategoriaM" runat="server" CssClass="txt"></asp:TextBox>
                <asp:RegularExpressionValidator ValidationGroup="2" ID="CategoriaM" runat="server" ErrorMessage="*" Font-Bold="True" ControlToValidate="TxtCategoriaM" ForeColor="Red"></asp:RegularExpressionValidator>
            </div>
            <asp:Button ValidationGroup="2" ID="Button2" runat="server" Text="Modificar" OnClick="Button2_Click" />
            <asp:Label ID="Label15" runat="server" Text=""></asp:Label>
        </div>
    </div>

    <!-- ******Bajas****** -->
    <div class="Principales">
        <div>
            <div class="titulares">
                <h2>Bajas de clientes</h2>
            </div>

            <div class="labelesp">
                <asp:Label ID="Label13" runat="server" Text="Introduce el Id a eliminar"></asp:Label>
            </div>

            <div class="txtboxesp">
                <asp:DropDownList ID="ddlIdB" runat="server" DataSourceID="SqlDataSource1" DataTextField="id" DataValueField="id"></asp:DropDownList>
                <asp:Button ID="Button4" runat="server" Text="Borrar" />
            </div>
            <div class="dtpck">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1" EmptyDataText="No hay registros de datos para mostrar." AllowPaging="True" AllowSorting="True" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Width="413px">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                        <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                        <asp:BoundField DataField="apellido1" HeaderText="apellido1" SortExpression="apellido1" />
                        <asp:BoundField DataField="apellido2" HeaderText="apellido2" SortExpression="apellido2" />
                        <asp:BoundField DataField="ciudad" HeaderText="ciudad" SortExpression="ciudad" />
                        <asp:BoundField DataField="categor&#237;a" HeaderText="categor&#237;a" SortExpression="categor&#237;a" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ASPMacroEjercicioJuevesConnectionString1 %>" DeleteCommand="DELETE FROM [cliente] WHERE [id] = @id" InsertCommand="INSERT INTO [cliente] ([id], [nombre], [apellido1], [apellido2], [ciudad], [categor&#237;a]) VALUES (@id, @nombre, @apellido1, @apellido2, @ciudad, @categor&#237;a)" SelectCommand="SELECT [id], [nombre], [apellido1], [apellido2], [ciudad], [categor&#237;a] FROM [cliente]" UpdateCommand="UPDATE [cliente] SET [nombre] = @nombre, [apellido1] = @apellido1, [apellido2] = @apellido2, [ciudad] = @ciudad, [categor&#237;a] = @categor&#237;a WHERE [id] = @id">
                    <DeleteParameters>
                        <asp:Parameter Name="id" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="id" Type="Int32" />
                        <asp:Parameter Name="nombre" Type="String" />
                        <asp:Parameter Name="apellido1" Type="String" />
                        <asp:Parameter Name="apellido2" Type="String" />
                        <asp:Parameter Name="ciudad" Type="String" />
                        <asp:Parameter Name="categor&#237;a" Type="Int32" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="nombre" Type="String" />
                        <asp:Parameter Name="apellido1" Type="String" />
                        <asp:Parameter Name="apellido2" Type="String" />
                        <asp:Parameter Name="ciudad" Type="String" />
                        <asp:Parameter Name="categor&#237;a" Type="Int32" />
                        <asp:Parameter Name="id" Type="Int32" />
                    </UpdateParameters>
                </asp:SqlDataSource>
                <asp:Label ID="Label16" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </div>
    
</asp:Content>

