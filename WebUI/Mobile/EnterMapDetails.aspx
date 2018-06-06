<%@ Page Title="Enter Map Details" Language="C#" MasterPageFile="~/MobileMaster.master" AutoEventWireup="true" CodeFile="EnterMapDetails.aspx.cs" Inherits="Mobile_EnterMapDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        .label {
            width: 300px;
            border: 1px solid black;
            text-align: left;
            margin-bottom: 10px;
            .container

        {
            margin-top: 50px;
        }

        .jumbotron {
            margin-top: 40px;
            height: 300px;
        }

        button {
            margin-top: 10px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">

        <center><h1>Enter Map Details</h1>
    <div class="label"><label for="Village">Village :</label>
        <asp:Label ID="lblVillage" runat="server"></asp:Label>
    </div>
        
       
     <div class="label"> <label for="Scheme">Scheme :</label>
        </div>
       
     
        <div class="label"><label for="Year">Year :</label></div>
   
        <div class="label"><label for="Purpse">Purpose : </label></div>
      
    <div class="label"> <label for="Budget">Estimated Budget :</label></div>
       
        </center>
        <center>
      <button type="submit" class="btn btn-primary">Start</button>
        <button type="submit" class="btn btn-primary">Stop</button>
            </center>


        <br /><br />
        <div class="jumbotron">
            <h1>Map</h1>
        </div>
    </div>

    </div>
     
</asp:Content>

