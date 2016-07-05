<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminPanel.Master" AutoEventWireup="true" CodeBehind="AccountManager.aspx.cs" Inherits="HolyInnocents.admin.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <section id="main" class="column">


        <asp:Literal ID="messageLiteral" runat="server"></asp:Literal>


        <article class="module width_full">
            

			        <header><h3>Administrator Manager</h3></header>
                        
				        <div class="module_content">
                            <fieldset>
                                <asp:TextBox ID="txtAdminName" Enabled="false" runat="server"></asp:TextBox>
                            </fieldset>
						    <fieldset>
							    <label>Password:</label>
                                <asp:CheckBox ID="checkUpdatePassword" Text="Update Passsword" runat="server" /><br />
							    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
						    </fieldset>
						        
				        </div>
			        <footer>
                        
				        <div class="submit_link">
					        <asp:Button ID="Submit" runat="server" Text="Update" OnClick="updateAccount" />
				        </div>
			        </footer>
        </article>
    </section>



    </form>


</asp:Content>
