<%@ Page Title="WebFormAdoNet" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormAdoNet.aspx.cs"   
Inherits="Web_Api_With_ADO.WebFormAdoNet" %>  

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
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
                        <asp:Button ID="ButtonId" runat="server" Text="Submit" OnClick="ButtonId_Click" /></td>  
                </tr>  
            </table>  
        </div>  
    <div>  
        <asp:Label ID="Label1" runat="server"></asp:Label>  
    </div>  
    <div class="message">
        <asp:Literal ID="ltMessage" runat="server"></asp:Literal>
    </div>
    <table class="auto-style1">  
        <tr>  
            <td class="auto-style3">  
                <asp:Label ID="Label2" runat="server"></asp:Label></td>  
            <td>  
                <asp:Label ID="Label5" runat="server"></asp:Label></td>  
        </tr>  
        <tr>  
            <td class="auto-style3">  
                <asp:Label ID="Label3" runat="server"></asp:Label></td>  
            <td>  
                <asp:Label ID="Label6" runat="server"></asp:Label></td>  
        </tr>  
        <tr>  
            <td class="auto-style3">  
                <asp:Label ID="Label4" runat="server"></asp:Label></td>  
            <td>  
                <asp:Label ID="Label7" runat="server"></asp:Label></td>  
        </tr>  
    </table>  
    </body>  
    </html>
    </asp:Content>