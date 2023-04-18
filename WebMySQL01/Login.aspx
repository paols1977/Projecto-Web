<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebMySQL01.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Login</h2>
            <div>
                <label for="txtUsername">Username:</label>
                <input type="text" id="txtUsername" name="txtUsername" runat="server" />
            </div>
            <div>
                <label for="txtPassword">Password:</label>
                <input type="password" id="txtPassword" name="txtPassword" runat="server" />
            </div>
            <div>
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            </div>
            <div>
                <asp:Label ID="lblError" runat="server" ForeColor="Red" />
            </div>
        </div>
    </form>
</body>
</html>
