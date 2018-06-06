<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="ViewAssignedJobs.aspx.cs" Inherits="Admin_ViewAssignedJobs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="Server">
    View Assigned Jobs
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content" runat="Server">
    <center><h1>View Assigned Jobs</h1></center>

    <div class="container">
        <table class="table">
            <thead>
                <tr>
                    <th>Village</th>
                    <th>Scheme</th>
                    <th>Year</th>
                    <th>Purpose</th>
                    <th>Estimated Budget</th>
                    <th>Path Stored</th>
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
                    <td>Dummy 5</td>
                    <td><input type="checkbox" checked /></td>
                    <td>
                        <button type="button" class="btn btn-link">Delete</button></td>
                    <td><a href="">View</a></td>
                </tr>

                <tr>
                    <td>Dummy 1</td>
                    <td>Dummy 2</td>
                    <td>Dummy 3</td>
                    <td>Dummy 4</td>
                    <td>Dummy 5</td>
                    <td><input type="checkbox"  /></td>
                    <td>
                        <button type="button" class="btn btn-link">Delete</button></td>
                    <td><a href="">View</a></td>
                </tr>

                <tr>
                    <td>Dummy 1</td>
                    <td>Dummy 2</td>
                    <td>Dummy 3</td>
                    <td>Dummy 4</td>
                    <td>Dummy 5</td>
                    <td><input type="checkbox" checked /></td>
                    <td>
                        <button type="button" class="btn btn-link">Delete</button></td>
                    <td><a href="">View</a></td>
                </tr>
            </tbody>
        </table>
    </div>
</asp:Content>

