using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplication2
{
    public partial class EditBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {


            string name = bookname.Text; // New book name
            string type = booktype.Text; // New book type
            string id = bookid.Text;     // ID to update
            string level = booklevel.Text; // New book level

            string path = Server.MapPath("BooksData.txt");

            // Read all lines from the file into a List
            var bookDetails = File.ReadAllLines(path).ToList();

            // Iterate and update the line with the matching ID
            for (int i = 0; i < bookDetails.Count; i++)
            {
                var parts = bookDetails[i].Split(' ');

                // Ensure we trim whitespace for accurate comparison
                if (parts[0].Trim() == id)
                {
                    bookDetails[i] = $"{id}, {name}, {type}, {level}";
                    File.WriteAllLines(path, bookDetails);
                    return;
                }
            }

            lblmsg.Text = "Book has been edited successfully!";
            lblmsg.Visible = true;



        }
    }
}