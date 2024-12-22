using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace assignments_1_ASP_
{
    public partial class validation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
               message.Text = "All validations passed successfully!";
                message.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                message.Text = "There are errors in the form.";
                message.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
}