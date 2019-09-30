using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTTP_5101_CONTROLSTRUCTURES
{
    public class Vehicle
    {
        // This class defines a vehicle.
        // It does not define any PARTICULAR vehicle, rather, it's a blueprint for all vehicles.
        // notice how our variable names now nicely fit into our definitions.

        //These variable names are now known as PROPERTIES of the VEHICLE class

        // Q: What does public mean?
        // public means that code outside this class (like if_lesson_2.aspx.cs) can access the information or modify it
        // private means that it is only accessible by the class itself.

        // Q: What is {get;set;}?
        // {get;set;} refers to how we are able to access the properties from the object (get) and change information for that object (set)
        // Refer to if_lesson_2.aspx on accessing information and changing 

        public int Vehicle_Weight { get; set; }
        public int Vehicle_Fuelefficiency { get; set; }
        public int Vehicle_Topspeed { get; set; }
        public int Vehicle_Engineheat { get; set; }
        public int Vehicle_Tirediameter { get; set; }

    }
}