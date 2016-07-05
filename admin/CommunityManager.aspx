<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminPanel.Master" AutoEventWireup="true" CodeBehind="CommunityManager.aspx.cs" Inherits="HolyInnocents.admin.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">
    <section id="main" class="column">

        <asp:Literal ID="messageLiteral" runat="server"></asp:Literal>


        <article class="module width_full">
            

			        <header><h3>Community Manager</h3></header>
                        
				        <div class="module_content">
                            <fieldset>
                                <asp:DropDownList ID="comboCommunityList" style="padding-left: 10px;" runat="server" AutoPostBack="true" OnSelectedIndexChanged="CommunitySelection" DataSourceID="ArticleListDataSource" DataTextField="Name" DataValueField="id">
                                    <asp:ListItem></asp:ListItem>
                                </asp:DropDownList>
                            </fieldset>
						        <fieldset>
							        <label>Community Name</label>
							        <asp:TextBox ID="txtCommunityName" runat="server"></asp:TextBox>
						        </fieldset>
						        <fieldset>
							        <label>Description</label>
							        <asp:TextBox ID="txtCommunityDescription" TextMode="MultiLine"  Rows="15" runat="server"></asp:TextBox>
                                    
						        </fieldset>
				        </div>
			        <footer>
                        
				        <div class="submit_link">
					        <asp:Button ID="Submit" runat="server" Text="Update" OnClick="updateButton"/>
				        </div>
			        </footer>
        </article>
    </section>

        <asp:SqlDataSource ID="ArticleListDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:AzureConnString %>" SelectCommand="SELECT [Name], [id] FROM [Communities]"></asp:SqlDataSource>

    </form>

</asp:Content>
