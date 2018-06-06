<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="ViewJobDetails.aspx.cs" Inherits="Admin_ViewJob" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="Server">
    View Job Details
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="Server">
    <style>
        .container-fluid {
            padding: 20px;
        }

            .container-fluid label {
                padding-right: 0px;
                margin-right: 150px;
                margin-left: 50px;
            }

        .mapContainer {
            width: 600px;
            height: 300px;
            border: 1px solid black;
            margin-top: 50px;
        }
    </style>

    <script>
        var map;
        function initMap() {
            map = new google.maps.Map(document.getElementById('siteMap'), {
                center: { lat: 30.251596, lng: 74.842456 },
                zoom: 8
            });
        }
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content" runat="Server">
    <center><h1>Job Details</h1></center>
    <div class="container-fluid">
        <center>
            <div class="container-fluid">
                <label>Village : </label>
                <asp:Label ID="lblVillageName" runat="server">

                </asp:Label>
                <label>Scheme  : </label>
                <asp:Label ID="lblSchemeName" runat="server">

                </asp:Label>
                <label>Year : </label>
                <asp:Label ID="lblYear" runat="server">

                </asp:Label>
            </div>
            <div class="container-fluid">
                <label>Purpose : </label>
                <asp:Label ID="lblPurpose" runat="server">

                </asp:Label>
                <label>Estimated Budget  : </label>
                <asp:Label ID="lblEstimatedBudget" runat="server">

                </asp:Label>
                <label>Remarks : </label>
                <asp:Label ID="lblRemarks" runat="server">

                </asp:Label>
             </div>
            <div class="mapContainer">
                <div class="jumbotron" id="siteMap">
                </div>
            </div>
            </center>
    </div>
</asp:Content>

