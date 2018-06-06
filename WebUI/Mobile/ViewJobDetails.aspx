<%@ Page Title="" Language="C#" MasterPageFile="~/MobileMaster.master" AutoEventWireup="true" CodeFile="ViewJobDetails.aspx.cs" Inherits="Mobile_ViewJobDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        .container{
            margin-top:50px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
    <div class="input-group mb-3">
  <div class="input-group-prepend">
    <label class="input-group-text" for="inputGroupSelect01">Village</label>
  </div>
  <select class="custom-select" id="inputGroupSelect01">
    <option selected>Choose...</option>
    <option value="1">Bathinda</option>
    <option value="2">Bathinda</option>
    <option value="3">Bathinda</option>
  </select>
</div>
     <div class="input-group mb-3">
  <div class="input-group-prepend">
    <label class="input-group-text" for="inputGroupSelect01">Scheme</label>
  </div>
  <select class="custom-select" id="inputGroupSelect01">
    <option selected>Choose...</option>
    <option value="1">Scheme</option>
    <option value="2">Scheme</option>
    <option value="3">Scheme</option>
  </select>
</div>
     <div class="input-group mb-3">
  <div class="input-group-prepend">
    <label class="input-group-text" for="inputGroupSelect01">Year</label>
  </div>
  <select class="custom-select" id="inputGroupSelect01">
    <option selected>Choose...</option>
    <option value="1">Year</option>
    <option value="2">Year</option>
    <option value="3">Year</option>
  </select>
</div>
        <table class="table">
  <thead>
    <tr>
      <th scope="col">#</th>
      <th scope="col">First</th>
      <th scope="col">Last</th>
      <th scope="col">Handle</th>
    </tr>
  </thead>
  
</table>
        </div>
</asp:Content>

