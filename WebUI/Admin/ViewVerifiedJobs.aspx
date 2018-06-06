<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="ViewVerifiedJobs.aspx.cs" Inherits="Admin_ViewVerifiedJobs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="Server">
    View Verified Jobs
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content" runat="Server">
    <center><h1>View Verified Jobs</h1></center>

    <div class="container">
        <div class="form-group">
            <label for="village">Village : </label>
            <select class="form-control">
                <option value="Bathinda">Bathinda</option>
                <option value="Bathinda">Bathinda</option>
                <option value="Bathinda">Bathinda</option>
                <option value="Bathinda">Bathinda</option>
            </select>
        </div>

        <br />
        <br />
        <table class="table">
            <thead>
                <tr>
                    <th>Scheme</th>
                    <th>Year</th>
                    <th>Purpose</th>
                    <th>Estimated Budget</th>
                    <th>#</th>
                    <th>#</th>
                </tr>
            </thead>

            <tbody>
                <tr>
                    <td>Dummy 1</td>
                    <td>Dummy 2</td>
                    <td>Dummy 3</td>
                    <td>Dummy 4</td>
                    <td><button type="button" class="btn btn-link">Mark as Grant</button></td>
                    <td><a href="">View</a></td>
                </tr>

                <tr>
                    <td>Dummy 1</td>
                    <td>Dummy 2</td>
                    <td>Dummy 3</td>
                    <td>Dummy 4</td>
                    <td><button type="button" class="btn btn-link">Mark as Grant</button></td>
                    <td><a href="">View</a></td>
                </tr>

                <tr>
                    <td>Dummy 1</td>
                    <td>Dummy 2</td>
                    <td>Dummy 3</td>
                    <td>Dummy 4</td>
                    <td><button type="button" class="btn btn-link">Mark as Grant</button></td>
                    <td><a href="">View</a></td>
                </tr>
            </tbody>
        </table>
    </div>
</asp:Content>

