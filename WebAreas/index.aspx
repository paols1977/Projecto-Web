<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebAreas.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table  border="1">
                <tr>
                    <td colspan="2">AREAS</td>
                   
                </tr>
                <tr>
                    <td style="width: 120px;"> <asp:Button ID="btnRetangulo" runat="server" Text="Retangulo" width="100px" OnClick="btnRetangulo_Click" /></td>
                    <td style="width: 120px;"> <asp:Button ID="btnQuadrado" runat="server" Text="Quadrado" width="100px" OnClick="btnQuadrado_Click"/> </td>
                  
                </tr>
                <tr>
                    <td > <asp:Button ID="btnCirculo" runat="server" Text="Circulo" width="100px" OnClick="btnCirculo_Click"/></td>
                    <td > <asp:Button ID="btnTriangulo" runat="server" Text="Triangulo" width="100px" OnClick="btnTriangulo_Click"/> </td>
                  
                  
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
