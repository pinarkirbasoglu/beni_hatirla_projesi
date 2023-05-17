<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="beni_hatirla_gp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Kullanıcı adı:<asp:TextBox ID="kuadi" runat="server"></asp:TextBox>
            <br />
            Şifre:<asp:TextBox ID="sif" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" Text="beni hatırla" />
        </div>
        <asp:Button ID="btn" runat="server" OnClick="btn_Click" Text="giriş" />
    </form>
</body>
</html>
