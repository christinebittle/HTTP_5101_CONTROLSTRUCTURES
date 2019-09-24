using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP_5101_CONTROLSTRUCTURES
{
    public partial class loop_lesson_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> Snacks = new List<string>();
            Snacks.Add("Pineapple");
            Snacks.Add("Candy Bars");
            Snacks.Add("Potato Chips");

            snacks_summary.InnerHtml = "";
            foreach (string snack in Snacks)
            {
                snacks_summary.InnerHtml += "Another snack I like is.. "+snack+"!<br>";

            }

            List<int> Luckynumbers = new List<int>();
            //TODO: add numbers
            //TODO write loop.


            laptop_features_summary.InnerHtml = "Good choice! You've selected the following:<br>";
            foreach(ListItem laptop_feature in laptop_features.Items)
            {
                if (laptop_feature.Selected == true)
                {
                    laptop_features_summary.InnerHtml += laptop_feature.Value+"<br>";
                } 
            }



        }
    }
}