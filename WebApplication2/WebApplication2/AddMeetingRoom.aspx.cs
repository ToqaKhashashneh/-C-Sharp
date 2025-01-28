using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.IO;

namespace WebApplication2
{
    public partial class AddMeetingRooms : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



        }

        protected void add_Click(object sender, EventArgs e)
        {
            string roomid = id.Text;
            string roomname = name.Text;
            string roomloc = loc.Text;
            string roomcap = cap.Text;

            string roomsData = $"{roomid} {roomname} {roomloc} {roomcap}";

            string file = Server.MapPath("RoomsData.txt");


            if (roomid == "" || roomname == "" || roomloc == "" || roomcap == "")
            {
                lblmsg.Text = "Room Inforamtion are required";
                lblmsg.Visible = true;
            }
            else
            {


                if (!File.Exists(file))
                {
                    File.Create(file);
                }

                File.AppendAllText(file, roomsData + Environment.NewLine);




                lblmsg.Text = "The Room has been added successfully!";
                lblmsg.Visible = true;

            }
        }
    }
}