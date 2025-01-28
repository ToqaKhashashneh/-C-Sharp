using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class AdminDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddBooks.aspx");
        }

        protected void editBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditBook.aspx");
        }

        protected void addMeeting_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddMeetingRoom.aspx");   
        }

        protected void SeeBooks_Click(object sender, EventArgs e)
        {
            Response.Redirect("AllBooks.aspx");
        }

        protected void SeeRooms_Click(object sender, EventArgs e)
        {
            Response.Redirect("AllMeetingRooms.aspx");
        }
    }
}