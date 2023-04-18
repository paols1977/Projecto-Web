<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormUpdate.aspx.cs" Inherits="WebMySQL01.WebFormUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Atualizar Formando</title>
</head>
<body style=" background-color: aquamarine">
    <form id="form1" runat="server">
        <div align="center">
            <h1 style="font-family:Blurlight">Atualizar Formando</h1>
            <h3 style="font-family:Blurlight" >by Paulo Sousa</h3>
            <hr />


            
            <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>


            <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Gênero"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem Value="M">Masculino</asp:ListItem>
                <asp:ListItem Value="F">Feminino</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Idade"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Adicionar" OnClick="Button1_Click" />
            <hr />

                   <asp:Label ID="Label9" runat="server" Text="ID"></asp:Label>
<br />
<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
<br />

<asp:Button ID="Button2" runat="server" Text="Pesquisar" OnClick="Button2_Click" />
<br />

<br />


            <asp:Label ID="Label4" runat="server" Text="Formandos"></asp:Label>
            <br />

    

<!--
<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
</asp:DropDownList>
            -->

            <br />
            <asp:Label ID="Label5" runat="server" Text="Nome"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Gênero"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList3" runat="server">
                <asp:ListItem Value="M">Masculino</asp:ListItem>
                <asp:ListItem Value="F">Feminino</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Idade"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
           
            <br />
            <asp:Button ID="Button3" runat="server" Text="Atualizar" OnClick="Button3_Click" /><br />
            <br />
            <asp:Button ID="Button4" runat="server" Text="Excluir" OnClick="Button4_Click" />
            <br />
            <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
