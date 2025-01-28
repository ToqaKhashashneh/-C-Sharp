using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplication2
{
    public partial class AddBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_Click(object sender, EventArgs e)
        {
            string BookID = id.Text;
            string BookName = name.Text;
            string BookType = type.Text;
            string BookLevel = level.Text;

            string BookDetails = $"{BookID} {BookName} {BookType} {BookLevel}";

            string file = Server.MapPath("BooksData.txt");

            if (BookID == "" || BookName == "" || BookType == "" || BookLevel == "")
            {
                lblmsg.Text = "Please fill all the fields";
                lblmsg.Visible = true;
            }

            else
            {
                if (!File.Exists(file))
                {
                    File.Create(file);
                }

                File.AppendAllText(file, BookDetails + Environment.NewLine);

                lblmsg.Text = "The Book has been added Successfully!";
                lblmsg.Visible = true;  
            }
        }
    }
}