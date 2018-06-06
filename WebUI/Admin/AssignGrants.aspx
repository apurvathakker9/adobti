<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="AssignGrants.aspx.cs" Inherits="Grants" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="Server">
    Assign Grants
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="Server">
    <style>
        body {
            font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
        }

        table td {
            height: 30px;
            width: 400px;
            text-align: right;
            padding: 5px 10px 5px 10px;
        }

        table tr {
            height: 30px;
        }

        table {
        }

        td select {
            height: 30px;
            width: 400px;
            border: 1px solid #ccc;
        }

        .add-grants {
            background-color: ghostwhite;
            padding: 20px 0px 20px 0px;
            margin-top: 50px;
            font-size: 18px;
        }

            .add-grants h3 {
                color: dodgerblue;
            }

        .grantvalue {
            width: 100%;
        }

            .grantvalue div {
                display: inline-block;
            }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content" runat="Server">
    <div class="container">
        <center>
              <div class="add-grants">
                  <center><h3>Add Grants</h3></center>
                  <table>
                      <tr>
                          <td>Village Name :</td>
                          <td><select>
                                <option value="Bathinda">Bathinda</option>
                                <option value="Bathinda">Bathinda</option>
                                <option value="Bathinda">Bathinda</option>
                                <option value="Bathinda">Bathinda</option>
                              </select> </td>
                      </tr>
                      <tr>
                            <td>Scheme Name :</td>
                            <td><select>
                                    <option value="Bathinda">Scheme 1</option>
                                    <option value="Bathinda">Scheme 2</option>
                                    <option value="Bathinda">Scheme 3</option>
                                    <option value="Bathinda">Scheme 4</option>
                                  </select> </td>
                        </tr>
                        <tr>
                                <td>Year :</td>
                                <td><input type="text" class="form-control"></td>
                        </tr>
                        <tr>
                                <td>Purpose :</td>
                                <td><input type="text" class="form-control"></td>
                            </tr>
                             
                                <tr>
                                    <td>Grant Received :</td>
                                    <td><input type="text" class="form-control"></td>
                                </tr>
                                <tr>
                                    <td>Grant Used :</td>
                                    <td><input type="text" class="form-control"></td>
                                </tr>
                                <tr>
                                    <td>Grant Balance :</td>
                                    <td><input type="text" class="form-control"></td>
                                </tr>
                                <tr>
                                        <td>Cert. no. and date :</td>
                                        <td><input type="text" class="form-control"></td>
                                    </tr>
                                    <tr>
                                            <td>Remarks :</td>
                                            <td><input type="text" class="form-control"></td>
                                        </tr>
                                        <tr>
                                                <td></td>
                                                <td><button class="btn btn-primary">ADD</button></td>
                                            </tr>

                  </table>

              </div>
            </center>
    </div>
</asp:Content>

