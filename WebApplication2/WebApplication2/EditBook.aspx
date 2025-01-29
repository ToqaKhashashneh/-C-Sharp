<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditBook.aspx.cs" Inherits="WebApplication2.EditBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">

</head>
<body>
    <form id="form1" runat="server">
        

        


        <div>
                   


  <section class="vh-100" style="background-color: burlywood;">

  <div class="container h-100">
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col-lg-12 col-xl-11">
        <div class="card text-black" style="border-radius: 25px;">
          <div class="card-body p-md-5">
            <div class="row justify-content-center">
              <div class="col-md-10 col-lg-6 col-xl-5 order-2 order-lg-1">

             
                 <asp:TextBox ID="Search" runat="server"></asp:TextBox> 
                  <asp:Button Text="Search" runat="server" ID="SearchBtn" placeholder="Insert Book ID" OnClick="SearchBtn_Click" />

                <p class="text-center h1 fw-bold mb-5 mx-1 mx-md-4 mt-4">Edit Book</p>

                

                  <div class="d-flex flex-row align-items-center mb-4">
                    <i class="fas fa-user fa-lg me-3 fa-fw"></i>
                    <div data-mdb-input-init class="form-outline flex-fill mb-0">
                      <label class="form-label" for="form3Example1c">Book ID</label>
                        <asp:TextBox ID="bookid" runat="server"></asp:TextBox>
                    </div>
                  </div>

                  <div class="d-flex flex-row align-items-center mb-4">
                    <i class="fas fa-envelope fa-lg me-3 fa-fw"></i>
                    <div data-mdb-input-init class="form-outline flex-fill mb-0">
                      <label class="form-label" for="form3Example3c">Book Name</label>
                     <asp:TextBox ID="bookname" runat="server"></asp:TextBox>
                    </div>
                  </div>

                  <div class="d-flex flex-row align-items-center mb-4">
                    <i class="fas fa-lock fa-lg me-3 fa-fw"></i>
                    <div data-mdb-input-init class="form-outline flex-fill mb-0">
                      <label class="form-label" for="form3Example4c">Book Type</label>
                   <asp:TextBox ID="booktype" runat="server"></asp:TextBox>
                    </div>
                  </div>

                  <div class="d-flex flex-row align-items-center mb-4">
                    <i class="fas fa-key fa-lg me-3 fa-fw"></i>
                    <div data-mdb-input-init class="form-outline flex-fill mb-0">
                      <label class="form-label" for="form3Example4cd">Book Level</label>
                     <asp:TextBox ID="booklevel" runat="server"></asp:TextBox>
                    </div>
                  </div>

                  <asp:Label runat="server" Visible="false" ID="SearchResult"></asp:Label>
                  <br /> <br />
                 <asp:Button ID="Editbtn" runat="server" Text="Edit Book" OnClick="Edit" />

                  <asp:Label ID="lblmsg" runat="server" Visible="false"></asp:Label>

               

              </div>
              <div class="col-md-10 col-lg-6 col-xl-7 d-flex align-items-center order-1 order-lg-2">

               
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
