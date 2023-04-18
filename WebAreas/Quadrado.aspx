<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Quadrado.aspx.cs" Inherits="WebAreas.Quadrado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

             <h1>Area do QUADRADO</h1>
            <br />
            Lado:<asp:TextBox ID="txtLado" runat="server"></asp:TextBox>
            <br /><br /><br />
           
        </div>
        <br />
        <div>
        <asp:Button ID="Btncalcular" runat="server" Text="Calcular" OnClick="Btncalcular_Click" /> &nbsp;&nbsp;<asp:Label ID="lblResultado" runat="server" Text="Label"></asp:Label>
            </div>
        <div> <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">VOLTAR</asp:LinkButton>


        </div>
    </form>
</body>
</html>
