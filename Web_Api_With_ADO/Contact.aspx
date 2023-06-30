<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Web_Api_With_ADO.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <link href="Custom_Css/StyleSheet.css" rel="stylesheet" type="text/css" />  
  <div class="row">
      <div class="col-md-10">
          <div class="styled-input wide multi">
              <div class="first-name" id="input-first-name">
                  <input type="text" name="fn" autocomplete="off" data-placeholder-focus="false"  ID="UsernameId" runat="server" class="form-control" />
                 <%-- <asp:TextBox name="fn" autocomplete="off" data-placeholder-focus="false" ID="UsernameId" runat="server"></asp:TextBox>--%>
                  <Label>User Name</Label>

                  <svg class="icon--check" width="21px" height="17px" viewBox="0 0 21 17" version="1.1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink">
                      <g id="Page-1" stroke="none" stroke-width="1" fill="none" fill-rule="evenodd" stroke-linecap="round">
                          <g id="UI-Elements-Forms" transform="translate(-255.000000, -746.000000)" fill-rule="nonzero" stroke="#81B44C" stroke-width="3">
                              <polyline id="Path-2" points="257 754.064225 263.505943 760.733489 273.634603 748"></polyline>
                          </g>
                      </g>
                  </svg>
                  <svg class="icon--error" width="15px" height="15px" viewBox="0 0 15 15" version="1.1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink">
                      <g id="Page-1" stroke="none" stroke-width="1" fill="none" fill-rule="evenodd" stroke-linecap="round">
                          <g id="UI-Elements-Forms" transform="translate(-550.000000, -747.000000)" fill-rule="nonzero" stroke="#D0021B" stroke-width="3">
                              <g id="Group" transform="translate(552.000000, 749.000000)">
                                  <path d="M0,11.1298982 L11.1298982,-5.68434189e-14" id="Path-2-Copy"></path>
                                  <path d="M0,11.1298982 L11.1298982,-5.68434189e-14" id="Path-2-Copy-2" transform="translate(5.564949, 5.564949) scale(-1, 1) translate(-5.564949, -5.564949) "></path>
                              </g>
                          </g>
                      </g>
                  </svg>
              </div>
              <div class="last-name" id="input-last-name">
                  <input type="text" name="ln" autocomplete="off" data-placeholder-focus="false"  ID="EmailId" runat="server" class="form-control" />
                  <%--<asp:TextBox name="ln" autocomplete="off" data-placeholder-focus="false" ID="EmailId" runat="server"></asp:TextBox>--%>
                  <Label>Email ID</Label>
                  <svg class="icon--check" width="21px" height="17px" viewBox="0 0 21 17" version="1.1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink">
                      <g id="Page-1" stroke="none" stroke-width="1" fill="none" fill-rule="evenodd" stroke-linecap="round">
                          <g id="UI-Elements-Forms" transform="translate(-255.000000, -746.000000)" fill-rule="nonzero" stroke="#81B44C" stroke-width="3">
                              <polyline id="Path-2" points="257 754.064225 263.505943 760.733489 273.634603 748"></polyline>
                          </g>
                      </g>
                  </svg>
                  <svg class="icon--error" width="15px" height="15px" viewBox="0 0 15 15" version="1.1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink">
                      <g id="Page-1" stroke="none" stroke-width="1" fill="none" fill-rule="evenodd" stroke-linecap="round">
                          <g id="UI-Elements-Forms" transform="translate(-550.000000, -747.000000)" fill-rule="nonzero" stroke="#D0021B" stroke-width="3">
                              <g id="Group" transform="translate(552.000000, 749.000000)">
                                  <path d="M0,11.1298982 L11.1298982,-5.68434189e-14" id="Path-2-Copy"></path>
                                  <path d="M0,11.1298982 L11.1298982,-5.68434189e-14" id="Path-2-Copy-2" transform="translate(5.564949, 5.564949) scale(-1, 1) translate(-5.564949, -5.564949) "></path>
                              </g>
                          </g>
                      </g>
                  </svg>
              </div>
              <div class="ContactId" id="input-ContactId">
                  <input type="text" name="ln" autocomplete="off" data-placeholder-focus="false"  ID="ContactId" runat="server" class="form-control" />
                  <%--<asp:TextBox  autocomplete="off" data-placeholder-focus="false" ID="ContactId" runat="server"></asp:TextBox>--%>
                  <%--<input type="text" name="city" id="city" autocomplete="off" data-placeholder-focus="false" />--%>
                  <Label>Contact</Label>
                  <svg class="icon--check" width="21px" height="17px" viewBox="0 0 21 17" version="1.1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink">
                      <g id="Page-1" stroke="none" stroke-width="1" fill="none" fill-rule="evenodd" stroke-linecap="round">
                          <g id="UI-Elements-Forms" transform="translate(-255.000000, -746.000000)" fill-rule="nonzero" stroke="#81B44C" stroke-width="3">
                              <polyline id="Path-2" points="257 754.064225 263.505943 760.733489 273.634603 748"></polyline>
                          </g>
                      </g>
                  </svg>
                  <svg class="icon--error" width="15px" height="15px" viewBox="0 0 15 15" version="1.1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink">
                      <g id="Page-1" stroke="none" stroke-width="1" fill="none" fill-rule="evenodd" stroke-linecap="round">
                          <g id="UI-Elements-Forms" transform="translate(-550.000000, -747.000000)" fill-rule="nonzero" stroke="#D0021B" stroke-width="3">
                              <g id="Group" transform="translate(552.000000, 749.000000)">
                                  <path d="M0,11.1298982 L11.1298982,-5.68434189e-14" id="Path-2-Copy"></path>
                                  <path d="M0,11.1298982 L11.1298982,-5.68434189e-14" id="Path-2-Copy-2" transform="translate(5.564949, 5.564949) scale(-1, 1) translate(-5.564949, -5.564949) "></path>
                              </g>
                          </g>
                      </g>
                  </svg>
              </div>
          </div>
      </div>
      <div class="col-md-2 no-pad-left-10">
          <asp:Button class="serach-btn" ID="ButtonId" runat="server" Text="GO_P" Onclick="ButtonId_Click_By_P" Width="77px" />
      </div>
      <div class="col-md-2 no-pad-left-10">
          <asp:Button class="serach-btn" ID="Button2" runat="server" Text="GO_Q" OnClick="ButtonId_Click_By_Q" Width="76px" />
      </div>
  </div>
      <div class="container">
        <asp:GridView ID="gdStudents" runat="server" CssClass="table table-bordered table-responsive">
        </asp:GridView>
    </div>
</asp:Content>