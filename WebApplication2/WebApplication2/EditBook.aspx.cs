using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection.Emit;
using System.Xml.Linq;
using System.IO;

namespace WebApplication2
{
    public partial class EditBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
        protected void SearchBtn_Click(object sender, EventArgs e)
        {

            string IDInput = Search.Text;
           


            string path = Server.MapPath("BooksData.txt");
            if (File.Exists(path))
            {

                string [] BooksSet = File.ReadAllLines(path); // Read all lines from the file

                for (int i = 0; i < BooksSet.Length; i++) //loop through them line by line
                {
                    string [] bookData = BooksSet[i].Split(' ');  //for each line, split the data by space


                    if (bookData [0] == IDInput)
                    {   bookid.Text = bookData[0];
                        bookname.Text = bookData[1];
                        booktype.Text = bookData[2];
                        booklevel.Text = bookData[3];
                        SearchResult.Text = "Book found!";
                        SearchResult.Visible = true;
                        break;
                    }

                    else
                    {
                        SearchResult.Text = "Book not found!";
                        SearchResult.Visible = true;
                        bookid.Text = "";
                        bookname.Text = "";
                        booktype.Text = "";
                        booklevel.Text = "";
                        

                    }

                }

            }
           


        }




        protected void Edit(object sender, EventArgs e)
        {


            string name = bookname.Text; // New book name
            string type = booktype.Text; // New book type
            string id = bookid.Text;     // ID to update
            string level = booklevel.Text; // New book level

            string path = Server.MapPath("BooksData.txt");


            var bookDetails = File.ReadAllLines(path);

            // Iterate and update the line with the matching ID
            for (int i = 0; i < bookDetails.Length; i++)
            {
                var parts = bookDetails[i].Split(' ');

                // Ensure we trim whitespace for accurate comparison
                if (parts[0].Trim() == id)
                {
                    bookDetails[i] = $"{id} {name} {type} {level}";
                    File.WriteAllLines(path, bookDetails);
                    break;
                }
            }

            lblmsg.Text = "Profile has been edited successfully!";
            lblmsg.Visible = true;



        }











    }
}