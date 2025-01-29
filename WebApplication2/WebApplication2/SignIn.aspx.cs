using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;    

namespace WebApplication2
{
    public partial class Sign_In : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignIn_Click(object sender, EventArgs e)
        {
            String Email = email.Text;
            String Password = password.Text;

            Session["UserEmail"] = email.Text;

            // Check if email is empty

            if (Email == "")
            { 
                lblmsg.Text = "Please enter your email";
                lblmsg.Visible = true;
            }

            string file = Server.MapPath("UserData.txt");

            //read from file (line by line) in array called users
            string[] users = File.ReadAllLines(file);

            //loop through the array
            foreach (string user in users)
            {
                //split each line into an array (the trigger is the space)
                string[] userElemnts = user.Split(',');

                //check if the email and password match
                if (userElemnts[1] == Email && userElemnts[2] == Password)
                {
                    //if they match, redirect to the user dashboard page
                    Response.Redirect("UserDashboard.aspx");
                    return; //exit the loop
                }

                //special case for the admin
                if (Email == "Admin@gmail.com" && Password == "123")
                {
                    Response.Redirect("AdminDashboard.aspx");
                }

            }

            lblmsg.Text = "Invalid Email or Password";
            lblmsg.Visible = true;

        }
    }
}