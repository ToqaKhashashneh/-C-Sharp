<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="WebApplication2.AdminDashboard" %>

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
      <asp:Button ID="addBook" runat="server" Text="Add Book" CssClass="btn btn-primary" OnClick="addBook_Click" />
      <asp:Button ID="editBook" runat="server" Text="Edit Book" CssClass="btn btn-primary" OnClick="editBook_Click" />
      <asp:Button ID="SeeBooks" runat="server" Text="See All Books" CssClass="btn btn-primary" OnClick="SeeBooks_Click" />
    
    
   
  </div>
</div>

            <div class="card" style="width: 18rem;">
  <div class="card-body">
    <h5 class="card-title">All Meetings</h5>
    <h6 class="card-subtitle mb-2 text-body-secondary">Card subtitle</h6>
    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
      <asp:Button ID="addMeeting" runat="server" Text="Add Meeting" CssClass="btn btn-primary" OnClick="addMeeting_Click" />
      <asp:Button ID="SeeRooms" runat="server" Text="See All Meeting Rooms" CssClass="btn btn-primary" OnClick="SeeRooms_Click" />
  </div>
</div>
        </div>
    </form>
</body>
</html>
