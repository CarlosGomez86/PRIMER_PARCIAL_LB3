<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Autores.aspx.cs" Inherits="TP_Blogs.Autores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="background-color:white; height: 606px;">
    <form id="form1" runat="server" >
        <div style="height: 602px;background-color:#5E59EE;" >
            <br />
            <br />
            <br />
            <asp:Panel ID="Panel1" runat="server" Height="75px" style="margin-top: -40px" HorizontalAlign="Center" BackColor="#5E59EE">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" Font-Underline="True" ForeColor="Black" Text="AUTORES" ></asp:Label>
                <br />
            </asp:Panel>
            <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Panel ID="Panel2" runat="server" Height="398px" HorizontalAlign="Center" BackColor="White">
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/imagenes/BotonCrear.png" Width="20%" PostBackUrl="~/CrearAutor.aspx" />
                <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/imagenes/botonConsultar.png" Width="20%" PostBackUrl="~/ConsultarAutor.aspx" />
                <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/imagenes/botonModificar.png" Width="20%" PostBackUrl="~/ActualizarAutores.aspx" />
                <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/imagenes/botonEliminar.png" Width="20%" PostBackUrl="~/EliminarAutores.aspx" />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/imagenes/flecha.png" PostBackUrl="~/Principal.aspx" Width="18%" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
