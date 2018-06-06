<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="AddScheme.aspx.cs" Inherits="Admin_AddScheme" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Add Scheme
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content" Runat="Server">
    <div style="width: 50%; margin-left:25%;">
        <center>
        <h1>Add New Scheme</h1>
    </center>
        <div class="form-group">
            <label for="txtScheme">Scheme Name :</label>
            <input type="text" class="form-control" id="txtSchemeName" placeholder="Enter Scheme Name">
        </div>

        <div class="form-group">
            <label for="txtGrantMoney">Grant Money :</label>
            <input type="text" class="form-control" id="txtGranteMoney" placeholder="Enter Grant Money">
        </div>

        <div class="form-group">
            <button id="addScheme" class="btn btn-primary">Add Scheme</button>
        </div>
    </div>
</asp:Content>

