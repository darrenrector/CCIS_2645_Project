<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Technicians.aspx.cs" Inherits="CallCenter.Technicians" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Technicians</title>
    <link href="Styles/Form.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 486px;
            top: 89px;
            position: absolute;
            height: 19px;
            width: 128px;
            bottom: 417px;
            text-align: right;
        }

        .auto-style3 {
            z-index: 1;
            left: 499px;
            top: 139px;
            position: absolute;
            width: 115px;
            text-align: right;
        }

        .auto-style4 {
            z-index: 1;
            left: 659px;
            top: 137px;
            position: absolute;
            width: 180px;
        }

        .auto-style5 {
            z-index: 1;
            left: 520px;
            top: 190px;
            position: absolute;
        }

        .auto-style6 {
            z-index: 1;
            left: 662px;
            top: 188px;
            position: absolute;
        }

        .auto-style7 {
            z-index: 1;
            left: 528px;
            top: 241px;
            position: absolute;
        }

        .auto-style8 {
            z-index: 1;
            left: 662px;
            top: 237px;
            position: absolute;
            width: 30px;
        }

        .auto-style9 {
            z-index: 1;
            left: 571px;
            top: 286px;
            position: absolute;
        }

        .auto-style10 {
            z-index: 1;
            left: 659px;
            top: 283px;
            position: absolute;
            width: 312px;
        }

        .auto-style11 {
            z-index: 1;
            left: 529px;
            top: 328px;
            position: absolute;
        }

        .auto-style12 {
            z-index: 1;
            left: 659px;
            top: 329px;
            position: absolute;
        }

        .auto-style13 {
            z-index: 1;
            left: 560px;
            top: 370px;
            position: absolute;
            height: 23px;
        }

        .auto-style14 {
            z-index: 1;
            left: 659px;
            top: 370px;
            position: absolute;
        }

        .auto-style15 {
            z-index: 1;
            left: 518px;
            top: 415px;
            position: absolute;
        }

        .auto-style16 {
            z-index: 1;
            left: 659px;
            top: 414px;
            position: absolute;
            width: 117px;
        }

        .auto-style17 {
            z-index: 1;
            left: 772px;
            top: 508px;
            position: absolute;
            width: 85px;
        }

        .auto-style18 {
            z-index: 1;
            left: 583px;
            top: 507px;
            position: absolute;
        }

        .auto-style19 {
            z-index: 1;
            left: 483px;
            top: 508px;
            position: absolute;
            right: 439px;
            width: 74px;
        }

        .auto-style21 {
            z-index: 1;
            left: 848px;
            top: 414px;
            position: absolute;
        }

        .auto-style22 {
            z-index: 1;
            left: 671px;
            top: 508px;
            position: absolute;
        }

        .auto-style23 {
            z-index: 1;
            left: 932px;
            top: 86px;
            position: absolute;
        }
        .auto-style24 {
            z-index: 1;
            left: 663px;
            top: 89px;
            position: absolute;
            width: 183px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Technicians</h1>
        </div>
        <asp:Label ID="lblTechID" runat="server" CssClass="auto-style1" Font-Bold="True" Text="Technician:"></asp:Label>
        <asp:Label ID="lblFirstName" runat="server" CssClass="auto-style3" Font-Bold="True" Text="*First Name:"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" CssClass="auto-style4" BackColor="White" Width="180px" Enabled="False"></asp:TextBox>
        <asp:TextBox ID="txtMiddleInit" runat="server" CssClass="auto-style6" BackColor="White" Width="180px" Enabled="False"></asp:TextBox>
        <asp:Label ID="lblLastName" runat="server" CssClass="auto-style7" Font-Bold="True" Text="*Last Name:"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" CssClass="auto-style9" Font-Bold="True" Text="Email:"></asp:Label>
        <asp:TextBox ID="txtEMail" runat="server" CssClass="auto-style10" BackColor="White" Enabled="False"></asp:TextBox>
        <asp:TextBox ID="txtDepartment" runat="server" CssClass="auto-style12" BackColor="White" Width="180px" Enabled="False"></asp:TextBox>
        <asp:Label ID="lblPhone" runat="server" CssClass="auto-style13" Font-Bold="True" Text="*Phone:"></asp:Label>
        <asp:TextBox ID="txtPhone" runat="server" CssClass="auto-style14" BackColor="White" Width="180px" Enabled="False"></asp:TextBox>
        <asp:Label ID="lblHourlyRate" runat="server" CssClass="auto-style15" Font-Bold="True" Text="*Hourly Rate:"></asp:Label>
        <asp:TextBox ID="txtHourlyRate" runat="server" CssClass="auto-style16" BackColor="White" Enabled="False"></asp:TextBox>
        <asp:Button ID="btnReturntoMain" runat="server" CssClass="auto-style17" Font-Bold="True" OnClick="btnReturntoMain_Click" Text="Main Menu" Height="26px" style="left: 772px; top: 508px" />
        <asp:Button ID="btnReturnList" runat="server" Font-Bold="True" OnClick="btnReturnList_Click" style="z-index: 1; position: absolute; top: 162px; left: 166px" Text="Return to Technicians Table" />
        <asp:Button ID="btnReset" runat="server" CssClass="auto-style18" Font-Bold="True" Text="Reset" Height="26px" Width="67px" OnClick="btnReset_Click" />
        <asp:Button ID="btnSubmit" runat="server" CssClass="auto-style19" Font-Bold="True" Text="Submit" Height="26px" OnClick="btnSubmit_Click" />
        <asp:Label ID="lblDenotes" runat="server" CssClass="auto-style21" ForeColor="Red" Text="*denotes required field"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style22" Font-Bold="True" Height="26px" Text="Cancel" Width="67px" OnClick="btnCancel_Click" />
        <asp:Button ID="btnNewTech" runat="server" CssClass="auto-style23" Enabled="False" Font-Bold="True" Text="New Technician" OnClick="btnNewTech_Click" />
        <p>
            <asp:Label ID="lblError" runat="server" Display="Dynamic" CssClass="auto-style21" ForeColor="Red" Text="Error Label" Font-Bold="True" Style="left: 491px; top: 460px"></asp:Label>
            
            
            
            <asp:DropDownList ID="ddlTechID" runat="server" CssClass="auto-style24">
            </asp:DropDownList>
            
            
            
        </p>
        <asp:Label ID="lblDepartment" runat="server" CssClass="auto-style11" Font-Bold="True" Text="Department:"></asp:Label>
        <p>
        <asp:TextBox ID="txtLastName" runat="server" CssClass="auto-style8" BackColor="White" Width="180px" Enabled="False"></asp:TextBox>
        </p>
        <asp:Label ID="lblMiddleInit" runat="server" CssClass="auto-style5" Font-Bold="True" Text="Middle Initial:"></asp:Label>
    </form>
</body>
</html>
