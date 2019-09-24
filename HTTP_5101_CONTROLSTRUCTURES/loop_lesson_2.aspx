<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loop_lesson_2.aspx.cs" Inherits="HTTP_5101_CONTROLSTRUCTURES.loop_lesson_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Print out all of the items in the "snacks" list</p>
            <div id="snacks_summary" runat="server"></div>

            <p>Print out all of the items in the "lucky numbers" list</p>
            <div id="luckynumbers_summary" runat="server"></div>

            <p>Print out all the laptop features selected in the checkbox below:</p>
            <asp:CheckBoxList runat="server" ID="laptop_features">
                <asp:ListItem Value="dualcore">Dual Core</asp:ListItem>
                <asp:ListItem Value="8gb-ram">8GB Ram</asp:ListItem>
                <asp:ListItem Value="ssd">500gb SSD</asp:ListItem>
                <asp:ListItem Value="diskdrive">Disk Drive</asp:ListItem>
            </asp:CheckBoxList>
            <div id="laptop_features_summary" runat="server"></div>

            <p>Let's say the base laptop is $500.</p>
            <ul>
                <li>Dual Core is +$20cad</li>
                <li>8GB RAM is +$70cad</li>
                <li>500gb ssd is +$100cad</li>
                <li>Disk Drive is +$15cad</li>
            </ul>
            <p>How can we print the updated cost in the summary?</p>
            
            <asp:Button runat="server" Text="Submit"/>
           
        </div>
    </form>
</body>
</html>
