using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTTP_5101_CONTROLSTRUCTURES
{
    public class Race
    {
        //This class defines a race
        //Once again, it's not any particular race, just the idea of a race.

        public DateTime Race_Time { get; set; }

        public Driver Race_Driver { get; set; }
        public Vehicle Race_Vehicle { get; set; }

        //This is known as a method.
        //It is an action that belongs to the concept.
        //another example would be "Bark" is a method of Class "Dog"
        public string PrintSummary()
        {
            string message = "Thank you for submitting! Confirm your details below:<br>";
            message += "Your Race Time is "+Race_Time.ToString()+"<br>";
            message += "Your driver's last name is "+Race_Driver.Driver_Lname+" and their identifier is "+Race_Driver.Driver_Identifier+"<br>";
            message += "Your Car specs are as follows <br>";
            message += "Top Speed "+Race_Vehicle.Vehicle_Topspeed;
            //Complete the rest!

            return message;
        }
    }
}