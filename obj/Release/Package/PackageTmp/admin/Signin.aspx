<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="Signin.aspx.cs" Inherits="HolyInnocents.admin.Signin" %>

    <html>
        <head>
          <meta charset="utf-8">
          <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
          <title>Administration Login</title>
          <link rel="stylesheet" href="../Content/AdminLogin.css">
        </head>
    <body> 
      <section class="container">
        <div class="login">
            <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
          <form id="loginform" runat="server">
            <p><asp:TextBox ID="txtLoginUsername" runat="server"></asp:TextBox></p>
            <p><asp:TextBox ID="txtLoginPassword" runat="server" TextMode="Password"></asp:TextBox></p>
            <p class="submit"><asp:Button ID="Login" type="submit"  runat="server" Text="Login" OnClick="LoginButton" /></p>
          </form>
        </div>
      </section>
    </body>
    </html>
