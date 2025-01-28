using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }


        protected void SignIn_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignIn.aspx");
        }
    }
}