<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="AddJob.aspx.cs" Inherits="Admin_AddJob" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="Server">
    Add Job
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content" runat="Server">
    <div style="width: 50%; margin-left: 25%;">
        <center>
        <h1>Add New Job</h1>
    </center>
        <div class="form-group">
            <label for="Village">Village :</label>
            <select class="form-control">
                <option value="Bathinda">Bathinda</option>
                <option value="Bathinda">Bathinda</option>
                <option value="Bathinda">Bathinda</option>
                <option value="Bathinda">Bathinda</option>
            </select>
        </div>

        <div class="form-group">
            <label for="Village">Scheme :</label>
            <select class="form-control">
                <option value="Bathinda">Scheme 1</option>
                <option value="Bathinda">Scheme 2</option>
                <option value="Bathinda">Scheme 3</option>
                <option value="Bathinda">Scheme 4</option>
            </select>
        </div>

        <div class="form-group">
            <label for="Village">Job :</label>
            <select class="form-control">
                <option value="Bathinda">Purpose 1</option>
                <option value="Bathinda">Purpose 2</option>
                <option value="Bathinda">Purpose 3</option>
                <option value="Bathinda">Purpose 4</option>
            </select>
        </div>


        <div class="form-group">
            <label for="txtYear">Year :</label>
            <input type="text" class="form-control" id="txtYear" placeholder="Enter Year">
        </div>        

        <div class="form-group">
            <label for="txtBudget">Extimated Budget :</label>
            <input type="text" class="form-control" id="txtBudget" placeholder="Enter Estimated Budget">
        </div>

        <div class="form-group">
            <button id="addScheme" class="btn btn-primary">Add New Job</button>
        </div>
    </div>

</asp:Content>

