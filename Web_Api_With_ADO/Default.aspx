<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web_Api_With_ADO._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <link href="Custom_Css/Default.css" rel="stylesheet" type="text/css" />
    <asp:Button ID="btnRedirect" runat="server" Onclick="btnRedirect_Click" Text="Redirect to Contact Page" />
 <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
 </div> 

 <div class="form-wrapper">

     <asp:TextBox ID="SearchValue" runat="server" placeholder="Search for..."></asp:TextBox>
      <div>  
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Exact" GroupName="type" />  
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Like" GroupName="type" />  
      </div>  
     <div>
              <asp:Button ID="Button1" runat="server" Text="GO_Q" Onclick="ButtonId_Click_With_Query" />
     <asp:Button ID="Button2" runat="server" Text="GO_P" Onclick="ButtonId_Click_With_Procedure" />
     </div>

</div>  

    <div class="container">
        <asp:GridView ID="gdStudents" runat="server" CssClass="table table-bordered table-responsive">
        </asp:GridView>
    </div>
</asp:Content>
