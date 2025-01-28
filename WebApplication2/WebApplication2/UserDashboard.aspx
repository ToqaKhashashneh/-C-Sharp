<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserDashboard.aspx.cs" Inherits="WebApplication2.UserDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>



 <div class="card" style="width: 18rem;">
<div class="card-body">
  <h5 class="card-title">All Books</h5>
  <h6 class="card-subtitle mb-2 text-body-secondary">Card subtitle</h6>
  <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
    <asp:Button ID="SeeBook" runat="server" Text="See Books" CssClass="btn btn-primary" OnClick="addBook_Click" />
 
</div>
     </div>


            
 <div class="card" style="width: 18rem;">
<div class="card-body">
  <h5 class="card-title">All Meeting Rooms</h5>
  <h6 class="card-subtitle mb-2 text-body-secondary">Card subtitle</h6>
  <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
    <asp:Button ID="SeeRoom" runat="server" Text="See Meeting Rooms" CssClass="btn btn-primary" OnClick="SeeRoom_Click" />
 
</div>
     </div>





        </div>
    </form>
</body>
</html>
