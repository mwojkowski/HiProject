<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminPanel.Master" AutoEventWireup="true" CodeBehind="NewAdmin.aspx.cs" Inherits="HolyInnocents.admin.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
    <section id="main" class="column">
        <article class="module width_full">

			        <header><h3>Administrator Manager</h3></header>
				        <div class="module_content">
                            <fieldset>
							    <label>Username:</label>
							    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
						    </fieldset>
						    <fieldset>
							    <label>Password:</label>
							    <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
						    </fieldset>
				        </div>
			        <footer>
                        
				        <div class="submit_link">
					        <asp:Button ID="Submit" runat="server" Text="Update" OnClick="createAdmin"/>
				        </div>
			        </footer>
        </article>
    </section>

        <asp:SqlDataSource ID="ArticleListDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:AzureConnString %>" SelectCommand="SELECT [id], [Username] FROM [Users]"></asp:SqlDataSource>

    </form>
</asp:Content>
