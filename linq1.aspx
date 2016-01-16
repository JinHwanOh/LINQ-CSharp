<%@ Page Language="C#" AutoEventWireup="true" CodeFile="linq1.aspx.cs" Inherits="linq1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>linQ1</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family: Arial, Helvetica, sans-serif">
    
        <asp:Label ID="Label1" runat="server" Text="SupplierID (1 to 29):"></asp:Label>
        <asp:TextBox ID="txtSId" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="cmdGet" runat="server" OnClick="cmdGet_Click" Text="Get Data" />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
