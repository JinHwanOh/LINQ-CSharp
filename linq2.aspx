<%@ Page Language="C#" AutoEventWireup="true" CodeFile="linq2.aspx.cs" Inherits="linq2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LinQ2</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family: Arial, Helvetica, sans-serif">
    
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="username" EmptyDataText="tUsers Table contains NO rows!">
            <Columns>
                <asp:BoundField DataField="username" HeaderText="Username" ReadOnly="True" SortExpression="username" />
                <asp:BoundField DataField="password" HeaderText="Password" SortExpression="password" />
                <asp:ButtonField ButtonType="Button" CommandName="selectRow" HeaderText="Select Row" ShowHeader="True" Text="Select">
                <ItemStyle HorizontalAlign="Center" />
                </asp:ButtonField>
            </Columns>
            <EmptyDataRowStyle ForeColor="Red" />
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Username: "></asp:Label>
        <asp:TextBox ID="txtUName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password: "></asp:Label>
        <asp:TextBox ID="txtPWord" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="cmdInsert" runat="server" OnClick="cmdInsert_Click" Text="Insert" />
&nbsp;
        <asp:Button ID="cmdUpdate" runat="server" OnClick="cmdUpdate_Click" Text="Update" />
&nbsp;
        <asp:Button ID="cmdDelete" runat="server" OnClick="cmdDelete_Click" Text="Delete" />
    
    </div>
    </form>
</body>
</html>
