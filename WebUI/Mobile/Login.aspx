<%@ Page Title="Login" Language="C#" MasterPageFile="~/MobileMaster.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Mobile_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        .container{
            margin-top:50px;
        }
        button{
            margin-top:20px;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
    <form>
      <div class="form-group">
        <label for="Email">Email :</label>
        <input type="email" class="form-control" id="Email" aria-describedby="emailHelp" placeholder="Enter email">
    
      </div>
      <div class="form-group">
        <label for="Password">Password</label>
        <input type="password" class="form-control" id="Password" placeholder="Password">
      </div>
      <div class="form-check">
        <input type="checkbox" class="form-check-input" id="exampleCheck1">
        <label class="form-check-label" for="Check">Check me out</label>
      </div>
      <button type="submit" class="btn btn-primary">Submit</button>
    </form>
     </div>
</asp:Content>

