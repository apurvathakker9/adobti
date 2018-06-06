<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="ViewGrants.aspx.cs" Inherits="Admin_GrantReports" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="Server">
    View Grants
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="Server">
    <style>
        body {
            font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
        }

        table td {
            height: 30px;
            border: 1px solid black;
        }

        table tr {
            height: 30px;
        }

        #head td {
            border: 1px solid black;
            width: 14%;
            padding: 0px 10px 0px 10px;
            text-align: center;
            font-weight: 700;
        }

        table {
            border: 1px solid black;
        }

        .tableview {
            margin-top: 40px;
        }

        .Area-selectors {
            position: relative;
            margin-top: 30px;
            height: 40px;
            padding-top: 10px;
            padding-bottom: 10px;
        }

            .Area-selectors div {
                display: inline;
                position: relative;
                padding-left: 15px;
            }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content" runat="Server">
    <div class="container">
        <div class="Area-selectors bg-light">
            <center>
                <div><div>Village :</div>
                <select>
                        <option value="Bathinda">Bathinda</option>
                        <option value="Bathinda">Bathinda</option>
                        <option value="Bathinda">Bathinda</option>
                        <option value="Bathinda">Bathinda</option>
                      </select>       
            </div>
            <%--<div><div>City :</div>
                <select>
                        <option value="Bathinda">Bathinda</option>
                        <option value="Bathinda">Bathinda</option>
                        <option value="Bathinda">Bathinda</option>
                        <option value="Bathinda">Bathinda</option>
                      </select>       
            </div>
            <div><div>Village :</div>
                <select>
                        <option value="Bathinda">Bathinda</option>
                        <option value="Bathinda">Bathinda</option>
                        <option value="Bathinda">Bathinda</option>
                        <option value="Bathinda">Bathinda</option>
                      </select>       
            </div>--%>
        
        </center>

        </div>
        <div class="tableview">
            <h4>
                <center>Grants received in Block Rampura in year 2013-14</center>
            </h4>
            <table>
                <tr id="head">                    
                    <td>Village name        
                    </td>
                    <td>Scheme name
                    </td>
                    <td>Sangat darshan date
                    </td>
                    <td>Grant Recieved
                    </td>
                    <td>Grant Used</td>
                    <td>Grant Balance</td>
                    <td>Cert. No</td>
                    <td>Cert. Date
                    </td>
                    <td>Remarks
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>

