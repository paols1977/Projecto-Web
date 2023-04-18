<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebSalario.aspx.cs" Inherits="WebSalario.WebSalario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>CALCULO SALARIO</h1>
    <br /><br />
    <form id="form1" runat="server">
        <div>
            SALARIO BRUTO<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="CALCULAR" OnClick="Button1_Click" />
            <br /><br />
            SEGURANÇA SOCIAL<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br /><br />
            IRS<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>%
            <br />
            VALOR IRS<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br /><br />
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <br /><br />
            SALARIO LIQUIDO<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

        </div>
    </form>
</body>
</html>
