<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Web_Api_With_ADO.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>

    <html>  
<head>  
    <title></title>  
    <style type="text/css">  
        .auto-style1 {  
            width: 100%;  
        }  
        .auto-style2 {  
            width: 100px;  
        }  
        .auto-style3 {  
            width: 95px;  
        }  
    </style>  
</head>  
<body style="margin-top:10px">  
     <div>  
            <table class="auto-style1">  
                <tr>  
                    <td class="auto-style2">  
                       <asp:Label runat="server" Text="User Name" ID="usernamelabelId"></asp:Label></td>  
                    <td>  
                       <asp:TextBox ID="UsernameId" runat="server"></asp:TextBox></td>  
                </tr>  
                <tr>  
                    <td class="auto-style2"></td>  
                    <td>  
                        <asp:Button ID="ButtonId" runat="server" Text="Submit" Onclick="ButtonId_Click" /></td>  
                </tr>  
            </table>  
        </div>  
     <div>  
            <table class="auto-style1">  
            <tr>  
                    <td class="auto-style2">  
                        <asp:Label runat="server" Text="Email ID"></asp:Label></td>  
                    <td>  
                        <asp:TextBox ID="EmailId" runat="server"></asp:TextBox></td>  
            </tr>  
                <tr>  
                    <td class="auto-style2"></td>  
                    <td>  
                        <asp:Button ID="Button2" runat="server" Text="Submit" Onclick="Button2_Click" /></td>  
                </tr>  
            </table>  
        </div>  
     <div>  
            <table class="auto-style1">  

                <tr>  
                    <td class="auto-style2">  
                        <asp:Label runat="server" Text="Contact"></asp:Label></td>  
                    <td>  
                        <asp:TextBox ID="ContactId" runat="server"></asp:TextBox></td>  
                </tr> 
                <tr>  
                    <td class="auto-style2"></td>  
                    <td>  
                        <asp:Button ID="Button3" runat="server" Text="Submit" Onclick="Button3_Click" /></td>  
                </tr>  
            </table>  
        </div>  
    <div>  
        <asp:Label ID="Label1" runat="server"></asp:Label>  
    </div>  
    <div class="container">
        <asp:GridView ID="gdStudents" runat="server" CssClass="table table-bordered table-responsive">
        </asp:GridView>
    </div>
    </body>  
    </html>
</asp:Content>
