<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="PromotionEngine.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width: 700px">
            <tr style="height: 35px; background-color: #007BFF; text-align-last: center; color: white; font-weight: bold">
                <td>SUK Master</td>
                <td>Active Promotions</td>
                <td>
                    <asp:Button ID="_btnReset" runat="server" Text="Reset" OnClick="_btnReset_Click" /></td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="GridView1" runat="server" Width="100%">
                    </asp:GridView>
                </td>
                <td>
                    <asp:GridView ID="GridView2" runat="server" Width="100%">
                    </asp:GridView>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <table style="width: 700px">
            <tr style="height: 35px; background-color: #007BFF; text-align-last: center; color: white; font-weight: bold">
                <td>SKU</td>
                <td>QTY</td>
                <td>Price</td>
                <td>Offer</td>
                <td>Value</td>
            </tr>
            <tr>
                <td style="width: 110px">
                    <asp:TextBox ID="_txtSKU1" runat="server" OnTextChanged="_txtSKU_TextChanged" AutoPostBack="true" Width="100px" Height="27px"></asp:TextBox></td>
                <td style="width: 110px">
                    <asp:TextBox ID="_txtQTY1" runat="server" OnTextChanged="_txtSKU_TextChanged" AutoPostBack="true" Width="100px" Height="27px"></asp:TextBox></td>
                <td style="width: 110px; text-align: center">
                    <asp:Label ID="_lblPrice1" runat="server"></asp:Label></td>
                <td>
                    <asp:Label ID="_lblOffer1" runat="server"></asp:Label></td>
                <td style="width: 110px">
                    <asp:Label ID="_lblValue1" runat="server" Text="0"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 110px">
                    <asp:TextBox ID="_txtSKU2" runat="server" OnTextChanged="_txtSKU_TextChanged" AutoPostBack="true" Width="100px" Height="27px"></asp:TextBox></td>
                <td style="width: 110px">
                    <asp:TextBox ID="_txtQTY2" runat="server" OnTextChanged="_txtSKU_TextChanged" AutoPostBack="true" Width="100px" Height="27px"></asp:TextBox></td>
                <td style="width: 110px; text-align: center">
                    <asp:Label ID="_lblPrice2" runat="server"></asp:Label></td>
                <td>
                    <asp:Label ID="_lblOffer2" runat="server"></asp:Label></td>
                <td style="width: 110px">
                    <asp:Label ID="_lblValue2" runat="server" Text="0"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 110px">
                    <asp:TextBox ID="_txtSKU3" runat="server" OnTextChanged="_txtSKU_TextChanged" AutoPostBack="true" Width="100px" Height="27px"></asp:TextBox></td>
                <td style="width: 110px">
                    <asp:TextBox ID="_txtQTY3" runat="server" OnTextChanged="_txtSKU_TextChanged" AutoPostBack="true" Width="100px" Height="27px"></asp:TextBox></td>
                <td style="width: 110px; text-align: center">
                    <asp:Label ID="_lblPrice3" runat="server"></asp:Label></td>
                <td>
                    <asp:Label ID="_lblOffer3" runat="server"></asp:Label></td>
                <td style="width: 110px">
                    <asp:Label ID="_lblValue3" runat="server" Text="0"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 110px">
                    <asp:TextBox ID="_txtSKU4" runat="server" OnTextChanged="_txtSKU_TextChanged" AutoPostBack="true" Width="100px" Height="27px"></asp:TextBox></td>
                <td style="width: 110px">
                    <asp:TextBox ID="_txtQTY4" runat="server" OnTextChanged="_txtSKU_TextChanged" AutoPostBack="true" Width="100px" Height="27px"></asp:TextBox></td>
                <td style="width: 110px; text-align: center">
                    <asp:Label ID="_lblPrice4" runat="server"></asp:Label></td>
                <td>
                    <asp:Label ID="_lblOffer4" runat="server"></asp:Label></td>
                <td style="width: 110px">
                    <asp:Label ID="_lblValue4" runat="server" Text="0"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="5">==================================================================================
                </td>
            </tr>
            <tr>
                <td colspan="4" style="text-align: right">Total
                </td>
                <td>
                    <asp:Label ID="_lblTotal" runat="server"></asp:Label></td>
            </tr>
        </table>
    </form>
</body>
</html>
