<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminPanel.Master" AutoEventWireup="true" CodeBehind="AdminManager.aspx.cs" Inherits="HolyInnocents.admin.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <section id="main" class="column">
        <article class="module width_full">
            

			        <header><h3>Administrator Manager</h3></header>
                        
				        <div class="module_content">
                            <fieldset>
                                <asp:DropDownList ID="comboAdminList" style="padding-left: 10px;" runat="server" AutoPostBack="True" OnSelectedIndexChanged="adminSelection" DataSourceID="ArticleListDataSource" DataTextField="Username" DataValueField="id">
                                    <asp:ListItem Value="0">Select Value</asp:ListItem>
                                    <asp:ListItem Value="0">Select Value</asp:ListItem>
                                </asp:DropDownList>
                            </fieldset>
						    <fieldset>
							    <label>Password:</label>
                                <asp:CheckBox ID="UpdatePassword" Text="Update Passsword" runat="server" /><br />
							    <asp:TextBox ID="txtPasswordReset" runat="server"></asp:TextBox>
						    </fieldset>
                            <fieldset>
							    <label>Status:</label>
                                <asp:RadioButtonList ID="radioActive" runat="server">
                                    <asp:ListItem Value="1">Active</asp:ListItem>
                                    <asp:ListItem Value="0">Inactive</asp:ListItem>
                                </asp:RadioButtonList>
						    </fieldset>
						        
				        </div>
			        <footer>
                        
				        <div class="submit_link">
					        <asp:Button ID="Submit" runat="server" Text="Update" OnClick="updateButton"/>
				        </div>
			        </footer>
        </article>
    </section>

        <asp:SqlDataSource ID="ArticleListDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:AzureConnString %>" SelectCommand="SELECT [id], [Username] FROM [Users]"></asp:SqlDataSource>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AzureConnString %>" SelectCommand="SELECT * FROM [Bulletins]"></asp:SqlDataSource>

    </form>

</asp:Content>
