using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class UserDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("AllBooks.aspx");
        }

        protected void SeeRoom_Click(object sender, EventArgs e)
        {
            Response.Redirect("AllMeetingRooms.aspx");
        }

        
    }
}