<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebMySQL01.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 47%;
        }
        .auto-style3 {
            width: 114px;
        }
        .auto-style4 {
            width: 95px;
        }
        body{

            background-color: lightblue;
        }
    </style>
</head>
<body>
    <form id="form1"  runat="server">
        <div align="center" >
            <br />
            <h1 style="font-family:Blurlight">Gestão de Formandos</h1><br />
            <h3 style="font-family:Blurlight">by Paulo Sousa</h3><br />
            <br />
            <table class="auto-style1" border="1">
                <tr>
                    <td class="auto-style4">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Inserir" />
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text  ="Atualizar" />
                    </td>
                    <td>
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Apagar" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Label ID="lblMsg" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">Nº de Formandos:</td>
                    <td>
                        <asp:Label ID="lblNFormandos" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">Idade Média:</td>
                    <td>
                        <asp:Label ID="lblMedia" runat="server"></asp:Label>
                        <asp:Button ID="btnCalcularMedia" runat="server" Text="Calcular Média" OnClick="btnCalcularMedia_Click" />

                    </td>
                </tr>

                <tr>
                    <td colspan="3"></td>

                </tr>
                <tr>
                    <td colspan="3">Lista de Formandos</td>

                </tr>
                <tr>
                    <td colspan="3">
                        <asp:GridView ID="GridView1" runat="server" AllowCustomPaging="True" AutoGenerateColumns="False" PageSize="5">
                            <Columns>
                                <asp:BoundField DataField="ID" HeaderText="ID" />
                                <asp:BoundField DataField="Nome" HeaderText="Nome" />
                                <asp:BoundField DataField="genero" HeaderText="Genero" />
                                <asp:BoundField DataField="idade" HeaderText="idade" />
                            </Columns>
                        </asp:GridView>


                    </td>

                </tr>
            </table>
            

        </div>
    </form>
</body>
</html>
