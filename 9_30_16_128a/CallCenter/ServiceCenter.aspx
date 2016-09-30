<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServiceCenter.aspx.cs" Inherits="CallCenter.ServiceCenter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Service Event</title>
    <link href="Styles/Form.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 538px;
            top: 139px;
            position: absolute;
        }

        .auto-style3 {
            z-index: 1;
            left: 524px;
            top: 186px;
            position: absolute;
        }

        .auto-style4 {
            text-align: left;
        }

        .auto-style5 {
            z-index: 1;
            left: 663px;
            top: 185px;
            position: absolute;
        }

        .auto-style6 {
            z-index: 1;
            left: 559px;
            top: 223px;
            position: absolute;
        }

        .auto-style7 {
            z-index: 1;
            left: 663px;
            top: 221px;
            position: absolute;
        }
        .auto-style8 {
            z-index: 1;
            left: 548px;
            top: 266px;
            position: absolute;
        }
        .auto-style9 {
            z-index: 1;
            left: 663px;
            top: 264px;
            position: absolute;
        }
        .auto-style10 {
            z-index: 1;
            left: 489px;
            top: 369px;
            position: absolute;
            right: 436px;
            width: 71px;
        }
        .auto-style11 {
            z-index: 1;
            left: 596px;
            top: 369px;
            position: absolute;
        }
        .auto-style12 {
            z-index: 1;
            left: 682px;
            top: 369px;
            position: absolute;
        }
        .auto-style13 {
            z-index: 1;
            left: 663px;
            top: 140px;
            position: absolute;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Service Event</h1>
        </div>
        <div class="auto-style4">

            <asp:Label ID="lblClientID" runat="server" CssClass="auto-style1" Font-Bold="True" Text="Client ID:"></asp:Label>
            <asp:DropDownList ID="ddlClientID" runat="server" CssClass="auto-style13" Width="150px">
            </asp:DropDownList>
            <asp:Label ID="lblEventDate" runat="server" CssClass="auto-style3" Font-Bold="True" Text="Event Date:"></asp:Label>
            <asp:TextBox ID="txtEventDate" runat="server" CssClass="auto-style5" Width="150px"></asp:TextBox>
            <asp:Label ID="lblPhone" runat="server" CssClass="auto-style6" Font-Bold="True" Text="Phone:"></asp:Label>
            <asp:TextBox ID="txtPhone" runat="server" CssClass="auto-style7" Width="150px"></asp:TextBox>

            <asp:Label ID="lblContact" runat="server" CssClass="auto-style8" Font-Bold="True" Text="Contact:"></asp:Label>
            <asp:TextBox ID="txtContact" runat="server" CssClass="auto-style9" Width="150px"></asp:TextBox>

        </div>
        <asp:Button ID="btnSubmit" runat="server" CssClass="auto-style10" Font-Bold="True" Text="Submit" Enabled="False" height="26px" />
        <asp:Button ID="btnReset" runat="server" CssClass="auto-style11" Font-Bold="True" Text="Reset" Enabled="False" />
        <asp:Button ID="btnReturntoMain" runat="server" CssClass="auto-style12" Font-Bold="True" Text="Main Menu" OnClick="btnReturntoMain_Click" />
    </form>
</body>
</html>
