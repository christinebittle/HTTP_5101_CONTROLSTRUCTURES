<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="custom_validator.aspx.cs" Inherits="HTTP_5101_CONTROLSTRUCTURES.custom_validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Special Numbers</h1>
            <p>A special number is one that can be divided by 2, 3 or 5, or 10. Some examples:</p>
            <ul>
                <li>30</li>
                <li>60</li>
                <li>120</li>
            </ul>
            <section>
                <h2>Input a Special Number</h2>
                <asp:TextBox runat="server" ID="specialnumber_candidate"></asp:TextBox>
                <asp:CustomValidator runat="server" 
                    ControlToValidate="specialnumber_candidate" 
                    ErrorMessage="This is not a special number!" OnServerValidate="Specialnumber_Validate">

                </asp:CustomValidator>
                <div id="specialnumber_summary" runat="server"></div>
            </section>
            <asp:Button runat="server" Text="Submit" />


        </div>
    </form>
</body>
</html>
