<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="if_lesson_2.aspx.cs" Inherits="HTTP_5101_CONTROLSTRUCTURES.if_lesson_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
        
        <h1>FASCAR Vehicle Registration</h1>

        <section>
            <h2>What is the weight of your vehicle in kg?</h2>
            <asp:TextBox runat="server" ID="vehicle_weight"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="vehicle_weight"></asp:RequiredFieldValidator>
        </section>
        <section>
            <h2>What is the L/100km efficiency rating of your vehicle?</h2>
            <asp:DropDownList runat="server" ID="vehicle_fuelefficiency">
                <asp:ListItem Value="25-30">(25L-30L)/100km</asp:ListItem>
                <asp:ListItem Value="30-35">(30L-35L)/100km</asp:ListItem>
                <asp:ListItem Value="35-40">(35L-40L)/100km</asp:ListItem>
                <asp:ListItem Value="40-45">(40L-45L)/100km</asp:ListItem>
                <asp:ListItem Value="40-45">(45L-50L)/100km</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="vehicle_fuelefficiency"></asp:RequiredFieldValidator>
        </section>
        <section>
            <h2>What is the top speed in km/hr of your vehicle?</h2>
            <asp:TextBox runat="server" ID="vehicle_topspeed"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="vehicle_topspeed"></asp:RequiredFieldValidator>
        </section>
        <section>
            <h2>What is the max temperature of your vehicle in degrees C</h2>
            <asp:TextBox runat="server" ID="vehicle_engineheat"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="vehicle_engineheat"></asp:RequiredFieldValidator>
        </section>
        <section>
            <h2>What is the diameter in cm of your tires?</h2>
            <asp:TextBox runat="server" ID="vehicle_tirediameter"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="vehicle_tirediameter"></asp:RequiredFieldValidator>
        </section>
        
        <div runat="server" id="vehicle_summary"></div>
        <asp:Button runat="server" Text="Submit"/>
    </form>
</body>
</html>
