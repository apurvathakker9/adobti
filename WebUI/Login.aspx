<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link type="text/css" rel="stylesheet" href="Content/css/bootstrap.min.css" />
    <style>
        body{
            font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
        }
        #branding{
            background-color: white;
            color: orange;
            width: 500px;
            margin: 10px;
        }
        .form{
            width:500px;
            margin-left:32%;
            margin-top:5%;
            background-color: ghostwhite;
            padding: 10px;
        }
        .form img{
            border-radius: 50%;
            height: 150px;
            width: 150px;
            margin-bottom: 10px;
        }
        form button{
            float: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <header class="container-fluid">
        <div class="row">
            <div class="col bg-warning">
                <center>
                    <div id="branding">
                        <h1>
                            ADO Bathinda
                        </h1>
                    </div>
            </center>
            </div>
            
        </div>
    </header>
    <div class="form">
        <center>
            <img src="Content/images/avatar.png" alt="avatar">
        </center>
        <form action="/action_page.php">
        <div class="form-group">
          <label for="email">Email:</label>
          <input type="email" class="form-control" id="email" placeholder="Enter email" name="email">
        </div>
        <div class="form-group">
          <label for="pwd">Password:</label>
          <input type="password" class="form-control" id="pwd" placeholder="Enter password" name="pwd">
        </div>
        <div class="checkbox">
          <label><input type="checkbox" name="remember"> Remember me</label>
        </div>
        <button type="submit" class="btn btn-primary">Submit</button>
      </form>
    </div>
        </div>
    </form>
</body>
</html>
