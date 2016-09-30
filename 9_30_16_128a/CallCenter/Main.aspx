<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="CallCenter.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main</title>
    <style type="text/css">
        h1 {
            text-align: center;
        }

        .auto-style1 {
            position: absolute;
            top: 141px;
            left: 569px;
            z-index: 1;
            
        }

        .auto-style2 {
            position: absolute;
            top: 220px;
            left: 569px;
            z-index: 1;
            
        }

        .auto-style3 {
            position: absolute;
            top: 300px;
            left: 569px;
            z-index: 1;
            
        }

        .auto-style4 {
            position: absolute;
            top: 379px;
            left: 569px;
            z-index: 1;
            width: 251px;
            height: 47px;
            
        }
        .mainButtons {
            height: 387px;
        }
    </style>
    <link href="Styles/Form.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="Main" runat="server">
        <div>
            <h1>Main Menu</h1>
        </div>
        <div id="mainButtons">
            <asp:Button ID="btnServiceEvent" runat="server" CssClass="auto-style1" Text="Service Event" Width="251px" BorderColor="#3E9509" BorderStyle="Solid" BorderWidth="2px" Font-Bold="False" Height="47px" OnClick="btnServiceEvent_Click1" Font-Size="Large" TabIndex="1" />
            <asp:Button ID="btnReports" runat="server" CssClass="auto-style3" Enabled="False" Height="47px" Text="Reports" Width="251px" BorderColor="#3E9509" BorderStyle="Solid" BorderWidth="2px" Font-Bold="False" Font-Size="Large" TabIndex="3" />
            <asp:Button ID="btnManageTechnicians" runat="server" CssClass="auto-style4" Text="Manage Technicians" BorderColor="#3E9509" BorderStyle="Solid" BorderWidth="2px" Font-Bold="False" OnClick="btnManageTechnicians_Click" Font-Size="Large" TabIndex="4" />
            <asp:Button ID="btnResolution" runat="server" CssClass="auto-style2" Height="47px" Text="Problem Resolution" Width="251px" BorderColor="#3E9509" BorderStyle="Solid" BorderWidth="2px" Font-Bold="False" Font-Size="Large" TabIndex="2" OnClick="btnResolution_Click" Enabled="False" />
        </div>
    </form>
</body>
</html>
