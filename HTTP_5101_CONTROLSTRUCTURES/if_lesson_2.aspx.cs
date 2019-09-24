using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

                    //Gather information and store it as a variable
                    int Vehicle_Weight = Convert.ToInt32(vehicle_weight.Text);
                    string Vehicle_Fuelefficiency = vehicle_fuelefficiency.SelectedValue;
                    int Vehicle_Topspeed = Convert.ToInt32(vehicle_topspeed.Text);
                    int Vehicle_Engineheat = Convert.ToInt32(vehicle_engineheat.Text);
                    int Vehicle_Tirediameter = Convert.ToInt32(vehicle_tirediameter.Text);

                    //These questions will be answered in a code-along during class.

                    //Write an if statement to check if the weight is over 1800kg -- too heavy
                    if (Vehicle_Weight > 1800)
                    {
                        vehicle_summary.InnerHtml += "Your car is too heavy<br>";
                    }

                    //Write an if statement to check if the weight is under 1200kg -- too  light

                    //Write an if statement to check if the engineheat is more than 1250degrees C -- too hot



                    /*
                        Write an if statment to check IF
                        the topspeed is over 320km/hr -- too fast
                        OR
                        the topspeed is under 200km/hr -- too slow
                    */
                    if (Vehicle_Topspeed > 320 || Vehicle_Topspeed < 200)
                    {
                        vehicle_summary.InnerHtml += "Your car is either too fast or too slow.";
                    }


                    /*
                        Write an if statement to check IF
                        the dire diameter is under 36cm -- too small
                        OR
                        the dire diameter is over 41cm -- too big
                    */


                    /*
                        Write an if statement to check IF
                        the topspeed is over 300km/hr
                        and
                        the fuel efficiency is under 40L/100km
                    */
                }
            }
        }
    }
}