<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditBook.aspx.cs" Inherits="WebApplication2.EditBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
            <asp:TextBox class="form-label" for="form3Example4cdg" ID="bookid" runat="server" placeholder="ID"></asp:TextBox>
            <asp:TextBox class="form-label" for="form3Example4cdg" ID="bookname" runat="server" placeholder="Book Name"></asp:TextBox>
            <asp:TextBox class="form-label" for="form3Example4cdg" ID="booktype" runat="server" placeholder="Book Type"></asp:TextBox>
            <asp:TextBox class="form-label" for="form3Example4cdg" ID="booklevel" runat="server"placeholder="Book Level"></asp:TextBox>
            <asp:Button class="btn btn-success btn-block btn-lg gradient-custom-4 text-body" OnClick="Unnamed_Click" runat="server" Text="edit book" />
            <asp:Label ID="lblmsg" runat="server" Visible="false" />
        </div>
    


        
    </form>
</body>
</html>
