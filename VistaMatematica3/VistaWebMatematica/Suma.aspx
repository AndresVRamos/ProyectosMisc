<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Suma.aspx.cs" Inherits="VistaWebMatematica.Suma" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitulo" runat="server" Text="ValorA"></asp:Label>
            <asp:TextBox ID="txtbxValorA" runat="server"></asp:TextBox>
            
        </div>
        <div> 
            <asp:Label ID="lblTitulo2" runat="server" Text="ValorB"></asp:Label>
            <asp:TextBox ID="txtbxValorB" runat="server"></asp:TextBox>
            
        </div>
        <div>
            <asp:Button ID="btnResultado" runat="server" Text="Resultado" OnClick="btnResultado_Click" />
        </div>
    </form>
</body>
</html>
