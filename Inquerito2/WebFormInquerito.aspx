<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormInquerito.aspx.cs" Inherits="Inquerito2.WebFormInquerito" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>inquerito</title>
     <link href= "css/folhaestilo.css" rel="stylesheet" type ="text/css" />

</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h3>Inquerito de Teste</h3>
            Nome:<asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
<br /><br />
Distrito:<br />
            <asp:ListBox ID="lstCidades" runat="server" rows="1">
                 <asp:ListItem Value="SemCidade">---</asp:ListItem>
            <asp:ListItem Value="Lisboa">Lisboa</asp:ListItem>
                <asp:ListItem Value="Porto">Porto</asp:ListItem>
                <asp:ListItem Value="Faro">Faro</asp:ListItem>
                
            </asp:ListBox>
            <br /><br />
            Pratos favoritos<br />
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Pizza" />
            <asp:CheckBox ID="CheckBox2" runat="server" Text="Bife" />
            <asp:CheckBox ID="CheckBox3" runat="server" Text="Refogado" />
            <br /><br />
            Clube:<br />
            <asp:RadioButton ID="RadioButton1" runat="server" Text="FCP" GroupName="Clube"/>  
            <asp:RadioButton ID="RadioButton2" runat="server" Text="SCP" GroupName="Clube" />
             <asp:RadioButton ID="RadioButton3" runat="server" Text="SLB" GroupName="Clube"/>

            <br /><br />
            <asp:Button ID="Button1" runat="server" Text="SUBMETER" OnClick="Button1_Click" />
            <br /><br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
