<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditData.aspx.cs" Inherits="Web_Api_With_ADO.EditData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
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
                    <td>
                        <asp:RequiredFieldValidator runat="server" ID="rfvUserName" ControlToValidate="UsernameId" ErrorMessage="Enter UserName*" />
                    </td>
                </tr>  
                <tr>  
                    <td class="auto-style2">  
                        <asp:Label runat="server" Text="Email ID"></asp:Label></td>  
                    <td>  
                        <asp:TextBox ID="EmailId" runat="server"></asp:TextBox></td>  

                </tr>  
                <tr>  
                    <td class="auto-style2">  
                        <asp:Label runat="server" Text="Contact"></asp:Label></td>  
                    <td>  
                        <asp:TextBox ID="ContactId" runat="server"></asp:TextBox></td>  
                </tr>  
                <tr>  
                    <td class="auto-style2"></td>  
                    <td>  
                        <asp:Button CssClass="btn btn-primary" ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" /></td>  
                    <td>  
                        <asp:Button CssClass="btn btn-warning" ID="btnCancle" runat="server" Text="Cancel" OnClick="btnCancle_Click" /></td>  

                </tr>  
            </table>  
        </div>  
    </body>  
    </html>
</asp:Content>
