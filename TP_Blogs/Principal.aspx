<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="TP_Blogs.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="min-height:100vh">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="min-height:100vh;width:100%;background-image:url(imagenes/blogs.jpeg);  background-position:center;background-color:black;background-repeat:no-repeat;">
    <form id="form1" runat="server" style="min-height:100vh; width:100%; height: 595px;">
       
        <asp:Panel ID="Panel1" runat="server" Height="100%" Width="30%" HorizontalAlign="Center"  >
            <br />
            <br />
            <br />
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" Height="15%" ImageUrl="~/imagenes/autores.jpg" Width="25%" PostBackUrl="~/Autores.aspx" />
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Medium" ForeColor="White" Text="Autores"></asp:Label>
            <br />
            <br />
            <br />
            <asp:ImageButton ID="ImageButton2" runat="server" Height="15%" ImageAlign="Middle" ImageUrl="~/imagenes/libro.jpg" style="margin-top: 0px" Width="25%" PostBackUrl="~/Blogs.aspx" />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Medium" ForeColor="White" Text="Blogs"></asp:Label>
            <br />
            <br />
            <br />
            <asp:ImageButton ID="ImageButton3" runat="server" Height="15%" ImageAlign="Middle" ImageUrl="~/imagenes/librosPorAutor.jpg" PostBackUrl="~/CantidadBlogs.aspx" style="margin-top: 0px" Width="25%" />
            <br />
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Medium" ForeColor="White" Text="Cantidad de Blogs"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Medium" ForeColor="White" Text="por Autor"></asp:Label>
        </asp:Panel>
       
    </form>
</body>
</html>
