<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormCalendario.aspx.cs" Inherits="WebCalendario.WebFormCalendario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Selecione a sua data de nascimento: <asp:Label ID="LblDataNascimento" runat="server" Text="Label"></asp:Label><br />
            <br /><br />
            <asp:Calendar ID="Calendar1" runat="server" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Width="350px" BackColor="White" BorderColor="White" BorderWidth="1px" Height="190px" NextPrevFormat="FullMonth" OnSelectionChanged="Calendar1_SelectionChanged">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                <TodayDayStyle BackColor="#CCCCCC" />
            </asp:Calendar>
            <br /><br />
            <asp:TextBox ID="TxtDataNascimento" runat="server"></asp:TextBox>&nbsp<asp:Button ID="BtnCarregarData1" runat="server" Text="Carregar Data" OnClick="BtnCarregarData1_Click" />
            <br /><br />
            <table border="0">
                <br />
                <tr>
                    <td>
                        Dia
                    </td>
                    <td>
                        Mês
                    </td>
                    <td>
                        Ano
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="DdlDia" runat="server"></asp:DropDownList>
                    </td>
                    <td>
                        <asp:DropDownList ID="DdlMes" runat="server"></asp:DropDownList>
                    </td>
                    <td>
                        <asp:DropDownList ID="DdlAno" runat="server"></asp:DropDownList>
                    </td>
                    <td>
                        <asp:Button ID="BtnCarregarData2" runat="server" Text="Carregar Data" OnClick="BtnCarregarData2_Click" />
                    </td>
                </tr>
            </table>
            <br /><br />
            <asp:Button ID="BtnCalcularIdade" runat="server" Text="Calcular Idade" OnClick="BtnCalcularIdade_Click" />&nbsp<asp:Label ID="LblCalcularIdade" runat="server" Text="Label"></asp:Label>
            <br /><br />
            <asp:Label ID="LblDiasAniversario" runat="server" Text="Label"></asp:Label>
        </div>

        <div></div>
        <asp:Label ID="lblDiasVividas" runat="server" ></asp:Label>
        <br />
        <asp:Image ID="Image1" runat="server" Width="100px" Height="100px" ImageUrl=""/>
        <br />
        <asp:Label ID="lblHoroscopo" runat="server"></asp:Label>
    </form>
</body>

</html>
