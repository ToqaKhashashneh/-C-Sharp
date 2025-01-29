using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;    

namespace WebApplication2
{
    public partial class UserProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["UserEmail"] == null)
            {
                Response.Redirect("Login.aspx"); 
            }




            string file = Server.MapPath("UserData.txt");
            if (File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);
                foreach (string line in lines)
                {
                    string[] data = line.Split(',');
                    if (data[1] == Session["UserEmail"].ToString())
                    {
                        ProfileName.Text = data[0];
                        ProfileEmail.Text = data[1];
                        ProfilePassword.Text = data[2];
                        ProfilePhone.Text = data[4];
                        ProfileCountry.Text = data[5];
                    }
                }
            }
        }



        protected void Button1_Click(object sender, EventArgs e)
        {



            string path = Server.MapPath("UserData.txt");


            var UsersData = File.ReadAllLines(path);

            for (int i = 0; i < UsersData.Length; i++)
            {
                var user = UsersData[i].Split(',');

                
                if (user[1].Trim() == Session["UserEmail"].ToString()) 
                {
                UsersData[i] = $"{ProfileName.Text},{ProfileEmail.Text},{ProfilePassword.Text},{ProfilePassword.Text},{ProfileCountry.Text}";
                    File.WriteAllLines(path, UsersData);
                    break;
                }
            }

            lblmsg.Text = "Profile has been edited successfully!";
            lblmsg.Visible = true;






        }
    }
}