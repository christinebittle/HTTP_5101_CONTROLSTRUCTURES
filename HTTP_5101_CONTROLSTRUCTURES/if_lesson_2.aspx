<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="if_lesson_2.aspx.cs" Inherits="HTTP_5101_CONTROLSTRUCTURES.if_lesson_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>FASCAR</title>
    <link rel="stylesheet" type="text/css" href="/Content/Site.css" />
</head>
<body>
    <form id="form1" runat="server">
        
        <h1>FASCAR Vehicle Registration</h1>

        <section>
            <h2>What is the weight of your vehicle in kg?</h2>
            <asp:TextBox runat="server" ID="vehicle_weight"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="vehicle_weight" ErrorMessage="Please Enter a weight in kg."></asp:RequiredFieldValidator>
            <asp:CustomValidator runat="server" ControlToValidate="vehicle_weight" OnServerValidate="Vehicle_Weight_Validate" ErrorMessage="This vehicle is not within the acceptable weight limit (1200kg-1800kg)"></asp:CustomValidator>
        </section>
        <section>
            <h2>What is the L/100km efficiency rating of your vehicle?</h2>
            <asp:DropDownList runat="server" ID="vehicle_fuelefficiency">
                <asp:ListItem Value="30">(25L-30L)/100km</asp:ListItem>
                <asp:ListItem Value="35">(30L-35L)/100km</asp:ListItem>
                <asp:ListItem Value="40">(35L-40L)/100km</asp:ListItem>
                <asp:ListItem Value="45">(40L-45L)/100km</asp:ListItem>
                <asp:ListItem Value="50">(45L-50L)/100km</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="vehicle_fuelefficiency" ErrorMessage="Please Enter a fuel efficiency"></asp:RequiredFieldValidator>
            <asp:CustomValidator runat="server" ControlToValidate="vehicle_fuelefficiency" OnServerValidate="Vehicle_Environment_Validate" ErrorMessage="This car is not environmentally friendly."></asp:CustomValidator>
        </section>
        <section>
            <h2>What is the top speed of your vehicle? (km/hr)</h2>
            <asp:TextBox runat="server" ID="vehicle_topspeed"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="vehicle_topspeed" ErrorMessage="Please enter a vehicle top speed in km/hr"></asp:RequiredFieldValidator>
            <asp:CustomValidator runat="server" ControlToValidate="vehicle_topspeed" OnServerValidate="Vehicle_Speed_Validate" ErrorMessage="The top-speed must be between 200km/hr and 320km/hr"></asp:CustomValidator>
            
            
        </section>
        <section>
            <h2>What is the max temperature of your vehicle in degrees C</h2>
            <asp:TextBox runat="server" ID="vehicle_engineheat"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="vehicle_engineheat" ErrorMessage="Please enter a max engine temperature in degrees C"></asp:RequiredFieldValidator>
            <asp:CustomValidator runat="server" ControlToValidate="vehicle_engineheat" OnServerValidate="Vehicle_Engine_Validate" ErrorMessage="This engine is too hot."></asp:CustomValidator>
          
            
        </section>
        <section>
            <h2>What is the diameter of your tire (in cm)?</h2>
            <asp:TextBox runat="server" ID="vehicle_tirediameter"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="vehicle_tirediameter" ErrorMessage="Please enter the diameter of the vehicle tire in cm"></asp:RequiredFieldValidator>
            <asp:CustomValidator runat="server" ControlToValidate="vehicle_tirediameter" OnServerValidate="Vehicle_Tire_Validate" ErrorMessage="The tire diameter is outside the acceptable threshold (36cm-41cm)"></asp:CustomValidator>
          
            
        </section>
        <section>
            <h2>What is your last name?</h2>
            <asp:TextBox runat="server" ID="driver_lname"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="driver_lname" ErrorMessage="Please enter the driver's name."></asp:RequiredFieldValidator>
        </section>
        <section>
            <h2>What is your identifier? (A letter and two digits)</h2>
            <asp:TextBox runat="server" ID="driver_identifier"></asp:TextBox>
            <asp:RegularExpressionValidator runat="server" ControlToValidate="driver_identifier" ValidationExpression="[a-zA-Z][\d][\d]" ErrorMessage="Please enter a valid identifier (letter and two digits)."></asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="driver_identifier" ErrorMessage="Please enter an identifier."></asp:RequiredFieldValidator>
        </section>


        <section>
            <h2>Which day do you wish to participate?</h2>
            <asp:RadioButtonList runat="server" ID="race_date">
                <asp:ListItem Text="October 5th" Value="2019/10/5"></asp:ListItem>
                <asp:ListItem Text="October 6th" Value="2019/10/6"></asp:ListItem>
            </asp:RadioButtonList>
        </section>
        <section>
            <h2>Which time do you wish to participate?</h2>
            <asp:DropDownList runat="server" ID="race_hour">
                <asp:ListItem Text="11:00am" Value="1100"></asp:ListItem>
                <asp:ListItem Text="2:00pm" Value="1400"></asp:ListItem>
                <asp:ListItem Text="5:00pm" Value="1700"></asp:ListItem>
            </asp:DropDownList>
        </section>
        <section>
            <div runat="server" id="vehicle_summary"></div>
            <asp:Button runat="server" Text="Submit"/>
        </section>
    </form>
</body>
</html>
