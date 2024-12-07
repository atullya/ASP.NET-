<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebFormDemo.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="l1" Text="Username" runat="server"></asp:Label>
            <asp:TextBox ID="usname"  runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="vd1" ControlToValidate="usname"  ErrorMessage="Username cannot be empty" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
            <br />
             <asp:Label ID="l2" Text="Password" runat="server"></asp:Label>
 <asp:TextBox ID="passw" TextMode="Password"  runat="server"></asp:TextBox>
 <asp:RequiredFieldValidator ID="vd2" ControlToValidate="passw"  ErrorMessage="Password cannot be empty" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
 <br />

            <asp:Label ID="l3" Text="RePassword" runat="server"></asp:Label>
<asp:TextBox ID="repass" TextMode="Password"  runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="vd3" ControlToValidate="repass"  ErrorMessage="RePassword cannot be empty" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
<asp:CompareValidator ID="vd4"  ControlToValidate="repass"  ControlToCompare="passw" ErrorMessage="Password Don't Match" runat="server" ></asp:CompareValidator>
<br />

            <asp:Button ID="l4" runat="server" Text="Login" OnClick="login_user"/>
            <asp:Label ID="l7" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
