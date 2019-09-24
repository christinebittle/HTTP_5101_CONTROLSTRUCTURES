using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP_5101_CONTROLSTRUCTURES
{
    public partial class custom_validator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    specialnumber_summary.InnerHtml = "";
                    int Specialnumber = Convert.ToInt32(specialnumber_candidate.Text);
                    specialnumber_summary.InnerHtml = Specialnumber.ToString()+" is a special number!";
                }
            }
        }

        //the custom validator function is OUTSIDE Page_Load
        protected void Specialnumber_Validate(object sender, ServerValidateEventArgs e)
        {
            int candidate = Convert.ToInt32(e.Value);
            if (candidate%2==0 && candidate%3==0 && candidate%10==0)
            {
                e.IsValid = true;
            }
            else
            {
                specialnumber_summary.InnerHtml = "";
                e.IsValid = false;
            }
               
        }
    }
}