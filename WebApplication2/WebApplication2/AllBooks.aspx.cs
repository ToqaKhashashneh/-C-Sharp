using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplication2
{
    public partial class AllBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            string file = Server.MapPath("BooksData.txt");
            string[] books = File.ReadAllLines(file);
            StringBuilder row = new StringBuilder();

            foreach (string book in books)
            {

                string[] BooksSet = book.Split(' ');

                row.Append("<tr>");
                row.Append($"<td> {BooksSet[0]} </td> ");
                row.Append($"<td> {BooksSet[1]} </td> ");
                row.Append($"<td> {BooksSet[2]} </td> ");
                row.Append($"<td> {BooksSet[3]} </td> ");
                row.Append("</tr>");

            }

            TableBody.InnerHtml = row.ToString();







        }
    }
}