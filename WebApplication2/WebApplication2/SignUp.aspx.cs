using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplication2
{
    public partial class Sign_Up : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignUp_Click(object sender, EventArgs e)
        {

            //Store the user input in variables (so i can use them later):
            string Name = name.Text;
            string Email = email.Text;
            string Password = password.Text;
            string ConfirmPass = ConfirmPassword.Text;
            string PhoneNum = Phone.Text;
            string Country = country.Text;



            
            //Store the user input in a string (one sentence):
            string userdata = $"{Name},{Email},{Password},{ConfirmPass},{PhoneNum},{Country}";

            //Server.MapPath() is a method that returns the physical file path
            //that corresponds to the specified virtual path on the Web server.

            // i used it to find the path of the file i want to write to.
            string file = Server.MapPath("UserData.txt");


            // to check if the user left any field empty (form validation):

            if (Name == "" || Email == "" || Password == "" || ConfirmPass == "" || PhoneNum == "" || Country == "")
            {
                Response.Write("<script>alert('All fields are required!');</script>");

                //lblmsg.Text = "All Fileds Are Required";
                lblmsg.Visible = true;
            }
            else
            {
                //if the file is not exist, create it.
                if (!File.Exists(file))
                {
                    File.Create(file);
                }

                // password validation:
                if (Password == ConfirmPass)
                {
                    lblmsg.Text = "Registration Successfull";
                    lblmsg.Visible = true;
                    //Append the user data to the file.

                    File.AppendAllText(file, userdata + Environment.NewLine);

                    //Go to SignIn page after registration.
                    Response.Redirect("SignIn.aspx");
                }
                else
                {
                    lblmsg.Text = "The Password doesn't match";
                    lblmsg.Visible = true;
                }

               
            }
        }
    }
}