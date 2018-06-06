<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="ViewSchemes.aspx.cs" Inherits="Admin_ViewSchemes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="Server">
    View Schemes
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="Server">
    <style>
        .table td tr{
            font-weight:lighter;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content" runat="Server">
    <center><h1>View Schemes</h1></center>

    <div style="margin-left:25%; width:50%;">
        <table class="table">
            <thead>
                <tr>
                    <th scope="col">Name</th>
                    <th scope="col">Grant Money</th>
                </tr>
            </thead>

            <tbody>
                <tr>                    
                    <td>Scheme 1</td>
                    <td>Some Amount</td>
                </tr>
                <tr>
                    <td>Scheme 2</td>
                    <td>Some Amount</td>
                </tr>
                <tr>
                    <td>Scheme 3</td>
                    <td>Some Amount</td>
                </tr>
                <tr>
                    <td>Scheme 4</td>
                    <td>Some Amount</td>
                </tr>
            </tbody>
        </table>
    </div>
</asp:Content>

