using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP_5101_CONTROLSTRUCTURES
{
    public partial class loop_lesson_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Print out the numbers 1 to 10
            string a1msg = "";
            for(int i = 1; i<11; i++)
            {
                a1msg += i.ToString() + ",";
            }
            a1.InnerHtml = a1msg;

            //Print out the numbers 1 to 25
            for (int i = 1; i<=25; i++)
            {

            }

            //Print out the numbers 10 to 35
            string a3msg = "";
            for(int i = 10; i<36; i++)
            {
                a3msg += i.ToString() + ",";
            }
            a3.InnerHtml = a3msg;

            //Print out the numbers 35 to 10

            //Print out the numbers 10 to 20, counting by 2s
            string a5msg = "";
            for(int i=10; i<=20; i = i + 2)
            {
                a5msg += i.ToString() + ",";
            }
            a5.InnerHtml = a5msg;
            //Print out the numbers 10 to 20, counting by 3s

            string a6msg = "";
            for (int i=10;i>0; i=i+3)
            {
                a6msg += i.ToString()+",";
            }
            a6.InnerHtml = a6msg;

            //Print out the numbers 50 to 23, counting by 4s
        }
    }
}