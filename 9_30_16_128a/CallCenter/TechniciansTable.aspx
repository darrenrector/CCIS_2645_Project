<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TechniciansTable.aspx.cs" Inherits="CallCenter.TechniciansTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Technicians Tab le</title>
    <link href="Styles/Form.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
            <div>
                <h1>Technicians Table</h1>
            </div>
            <asp:Label ID="lblError" runat="server" Font-Bold="True" Font-Size="15pt" ForeColor="Red" Style="z-index: 1; position: absolute; top: 516px; left: 41px" Text="Error Label"></asp:Label>
            <asp:GridView ID="gvTechnicians" runat="server"
                Style="border-style: solid; border-width: 1px; padding: 5px; z-index: 1; left: 278px; top: 74px; position: absolute; height: 150px; width: 750px; font-size: small; font-family: Arial, Helvetica, sans-serif;"
                AutoGenerateColumns="True" OnRowCommand="gvTechnicians_RowCommand">
                <Columns>
                    <asp:ButtonField CommandName="CHANGE" Text="Modify" />
                    <asp:ButtonField CommandName="DELETE" Text="Delete" />
                </Columns>
            </asp:GridView>
            <asp:Button ID="btnReturnMain" runat="server" OnClick="btnReturnMain_Click" Style="z-index: 1; position: absolute; top: 487px; left: 1164px" Text="Technicians" />
        </div>
    </form>
</body>
</html>
