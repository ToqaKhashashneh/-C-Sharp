<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="WebApplication2.UserProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            

<section class="vh-100" style="background-color: burlywood;">
  <div class="container py-5 h-100">
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col col-lg-6 mb-4 mb-lg-0">
        <div class="card mb-3" style="border-radius: .5rem;">
          <div class="row g-0">
            <div class="col-md-4 gradient-custom text-center text-white"
              style="border-top-left-radius: .5rem; border-bottom-left-radius: .5rem;">
              <img src="https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-chat/ava1-bg.webp"
                alt="Avatar" class="img-fluid my-5" style="width: 80px;" />

                        <asp:label class="form-label" Text="Profile Name"></asp:label> 
                      <asp:TextBox ID="ProfileName" runat="server" CssClass="form-control"></asp:TextBox>  
                  
          
              <i class="far fa-edit mb-5"></i>
            </div>
            <div class="col-md-8">
              <div class="card-body p-4">
                <h6>Information</h6>
                <hr class="mt-0 mb-4">
                <div class="row pt-1">
                  <div class="col-6 mb-3">

                      <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
                      <asp:TextBox ID="ProfileEmail" runat="server" CssClass="form-control"></asp:TextBox>  
                  
                  </div>
                  <div class="col-6 mb-3">
                      <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                      <asp:TextBox ID="ProfilePassword" runat="server" CssClass="form-control"></asp:TextBox>


           
                  </div>
                </div>
                
                <hr class="mt-0 mb-4">
                <div class="row pt-1">
                  <div class="col-6 mb-3">

                      <asp:Label ID="Label3" runat="server" Text="Phone"></asp:Label>
                      <asp:TextBox ID="ProfilePhone" runat="server" CssClass="form-control"></asp:TextBox>
                  </div>
                  <div class="col-6 mb-3">

                      
                      <asp:Label ID="Label4" runat="server" Text="Country"></asp:Label>
                      <asp:TextBox ID="ProfileCountry" runat="server" CssClass="form-control"></asp:TextBox>

                  </div>
                </div>


                  <asp:Label ID="lblmsg" runat="server" Visible="false" /></asp:Label>

                  <asp:Button class="btn btn-info btn-rounded" data-mdb-ripple-init Text="Save Changes" runat="server" ID="Button1" OnClick="Button1_Click"/>
                <div class="d-flex justify-content-start">
                  <a href="#!"><i class="fab fa-facebook-f fa-lg me-3"></i></a>
                  <a href="#!"><i class="fab fa-twitter fa-lg me-3"></i></a>
                  <a href="#!"><i class="fab fa-instagram fa-lg"></i></a>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</section>




        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>

</body>
</html>
