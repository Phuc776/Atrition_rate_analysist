<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 407px;
        }
        .auto-style2 {
            width: 407px;
            height: 26px;
        }
        .auto-style4 {
            width: 407px;
            height: 29px;
        }
        .auto-style5 {
            width: 331px;
        }
        .auto-style6 {
            width: 331px;
            height: 26px;
        }
        .auto-style7 {
            width: 331px;
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">Age</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Distance From Home</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtDistanceFromHome" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Education</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="DropDownListEducation" runat="server">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Percent Salary Hike</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtPercentSalaryHike" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Total Working Year</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtTotalWorkingYear" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Years At Company</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtYearsAtCompany" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Years In Current Role</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtYearsInCurrentRole" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Years Since Last Promotion</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtYearsSinceLastPromotion" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Years With Curr Manager</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtYearsWithCurrManager" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Dự Đoán" />
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Gửi thông tin về mail" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">outlook mail Username</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
&nbsp; To outlook mail</td>
                    <td>
                        <asp:TextBox ID="txtToUsername" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Password</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtPassWord" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <div>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
