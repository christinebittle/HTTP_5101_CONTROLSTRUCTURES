using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace HTTP_5101_CONTROLSTRUCTURES
{
    public partial class if_lesson_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Page.IsPostBack asks if we arrived here because the form posted to itself.
            //When we first visit the page, it's by using the URL
            //When we hit the button and client side validation passes
            //Then we arrive at the page a second time, and we can run the code here.
            if (Page.IsPostBack) {
                //Re-validates the code on the server side. can never be too careful!
                Page.Validate();
                //If everything seems okay, we can proceed.
                if (Page.IsValid)
                {


                    //wipe out any previous information inside the summary.
                    vehicle_summary.InnerHtml = "";

                    //Gather information for vehicle and store it as a variable
                    int Vehicle_Weight = Convert.ToInt32(vehicle_weight.Text);
                    int Vehicle_Fuelefficiency = Convert.ToInt32(vehicle_fuelefficiency.SelectedValue);
                    int Vehicle_Topspeed = Convert.ToInt32(vehicle_topspeed.Text);
                    int Vehicle_Engineheat = Convert.ToInt32(vehicle_engineheat.Text);
                    int Vehicle_Tirediameter = Convert.ToInt32(vehicle_tirediameter.Text);

                    //Gather information for driver and store it as a variable
                    string Driver_Lname = driver_lname.Text;
                    string Driver_Identifier = driver_identifier.Text;

                    //Gather information for the race and store it as a variable
                    string Race_Date = race_date.Text;
                    //This could be stored as an integer for validations, but will used as a string to convert to datetime
                    string Race_Hour = race_hour.Text;

                    //Learning how to use date format strings
                    //https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings

                    DateTime Race_Time = DateTime.ParseExact(Race_Date+" "+Race_Hour, "yyyy/M/d Hmm", System.Globalization.CultureInfo.InvariantCulture);

                    //We have our templates for Vehicle, Driver, and Race.

                    //instantiate a new instance of the Vehicle Class, the vehicle Object.
                    Vehicle Race_Vehicle = new Vehicle();
                    Race_Vehicle.Vehicle_Engineheat = Vehicle_Engineheat;
                    Race_Vehicle.Vehicle_Weight = Vehicle_Weight;
                    Race_Vehicle.Vehicle_Fuelefficiency = Vehicle_Fuelefficiency;
                    Race_Vehicle.Vehicle_Tirediameter = Vehicle_Tirediameter;
                    Race_Vehicle.Vehicle_Topspeed = Vehicle_Topspeed;

                    //instantiate a new instance of the driver class, the driver Object
                    Driver Race_Driver = new Driver();
                    Race_Driver.Driver_Lname = Driver_Lname;
                    Race_Driver.Driver_Identifier = Driver_Identifier;

                    //instantiate a new instance of the race class, the race object
                    Race Fascar_Race = new Race();
                    Fascar_Race.Race_Driver = Race_Driver;
                    Fascar_Race.Race_Vehicle = Race_Vehicle;
                    Fascar_Race.Race_Time = Race_Time;


                    vehicle_summary.InnerHtml = Fascar_Race.PrintSummary();

                }
            }
        }

        //Server Side Validation Functions

        //validation function on the speed of a vehicle
        protected void Vehicle_Speed_Validate (object sender, ServerValidateEventArgs e){
            //no empty inputs

            //How to tell if an input is a valid integer on the server side?
            //code referenced from Microsoft Sept 29, 2019
            //purpose: use TryParse to make sure that the vehicle speed is valid
            //link: https://docs.microsoft.com/en-us/dotnet/api/system.int32.tryparse?redirectedfrom=MSDN&view=netframework-4.8#System_Int32_TryParse_System_String_System_Int32__
            //what does out do? it allows us to use the variable (Vehicle_Topspeed) if the conversion succeeded.

            bool SpeedIsInteger = Int32.TryParse(e.Value, out int Vehicle_Topspeed);
            //The above line will set the Vehicle Topspeed
            //int Vehicle_Topspeed = Convert.ToInt32(e.Value);

            if (!SpeedIsInteger)
            {
                
                e.IsValid = false;
            }
            //check to see if the speed is more than 320km/hr or less than 200km/hr
            else if (Vehicle_Topspeed > 320 || Vehicle_Topspeed< 200)
            {
                e.IsValid = false;
            }
            else
            {
                e.IsValid = true;
            }
        }

        //validation function on the weight of the vehicle
        //make sure that the vehicle weight is between 1200kg and 1800kg
        protected void Vehicle_Weight_Validate(object sender, ServerValidateEventArgs e)
        {
            
        }

        //validation function on the engine heat of a vehicle
        protected void Vehicle_Engine_Validate(object sender, ServerValidateEventArgs e)
        {
            bool EngineHeatIsInteger = Int32.TryParse(e.Value, out int Vehicle_Engineheat);

            Debug.WriteLine("The reported Engine Heat is "+ Vehicle_Engineheat.ToString()+" and the bool is "+EngineHeatIsInteger);
            //int Vehicle_Engineheat = Convert.ToInt32(e.Value);
            //Write an if statement to check if the engineheat is more than 1250degrees C -- too hot

            if (!EngineHeatIsInteger)
            {
                e.IsValid = false;
            }
            else if (Vehicle_Engineheat > 1250)
            {
                e.IsValid = false;
            }
            else
            {
                e.IsValid = true;
            }
        }

        //validation function on the tires of a vehicle
        protected void Vehicle_Tire_Validate(object sender, ServerValidateEventArgs e)
        {
            bool DiameterIsInteger = Int32.TryParse(e.Value, out int Vehicle_Tirediameter);
            //int Vehicle_Tirediameter = Convert.ToInt32(e.Value);
            //Write an if statement to check if the engineheat is more than 1250degrees C -- too hot
            if (!DiameterIsInteger)
            {
                e.IsValid = false;
            }
            else if (Vehicle_Tirediameter < 36 || Vehicle_Tirediameter > 41)
            {
                e.IsValid = false;
            }
            else
            {
                e.IsValid = true;
            }
        }

        protected void Vehicle_Environment_Validate(object sender, ServerValidateEventArgs e)
        {
            //int Vehicle_Topspeed = Convert.ToInt32(vehicle_topspeed.Text);
            //int Vehicle_Fuelefficiency = Convert.ToInt32(vehicle_fuelefficiency.Text);
            bool SpeedIsInteger = Int32.TryParse(vehicle_topspeed.Text, out int Vehicle_Topspeed);
           

            bool EfficiencyIsInteger = Int32.TryParse(vehicle_fuelefficiency.Text, out int Vehicle_Fuelefficiency);
            if (!EfficiencyIsInteger)
            {
                e.IsValid = false;
            }
            else if (!SpeedIsInteger)
            {
                e.IsValid = false;
            }
            else if (Vehicle_Topspeed > 300 && Vehicle_Fuelefficiency > 40)
            {
                e.IsValid = false;
            }
            else
            {
                e.IsValid = true;
            }
        }

    }
}