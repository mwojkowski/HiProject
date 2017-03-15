<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/admin/AdminPanel.Master" ValidateRequest="false" CodeBehind="ManageArticle.aspx.cs" Inherits="HolyInnocents.admin.ManageArticle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <section id="main" class="column">

        <asp:Literal ID="messageLiteral" runat="server"></asp:Literal>

        <article class="module width_full">
            

			        <header><h3>Manage Article</h3></header>
                        
				        <div class="module_content">
						    <fieldset>
							    <label>Post Title(English)</label>
							    <asp:TextBox ID="txtEnglishTitle" runat="server"></asp:TextBox>
						    </fieldset>    
                            <fieldset>
							    <label>Post Title(Spanish)</label>
							    <asp:TextBox ID="txtSpanishTitle" runat="server"></asp:TextBox>
						    </fieldset>
                            <fieldset>
							    <label>Post Title(Polish)</label>
							    <asp:TextBox ID="txtPolishTitle" runat="server"></asp:TextBox>
						    </fieldset>
						    <fieldset>
							    <label>Content(English)</label>
							    <asp:TextBox ID="txtEnglishBody" TextMode="MultiLine" Rows="15" runat="server"></asp:TextBox>
						    </fieldset>
                            <fieldset>
							    <label>Content(Spanish)</label>
							    <asp:TextBox ID="txtSpanishBody" TextMode="MultiLine" Rows="15" runat="server"></asp:TextBox>
						    </fieldset>
                            <fieldset>
							    <label>Content(Polish)</label>
							    <asp:TextBox ID="txtPolishBody" TextMode="MultiLine" Rows="15" runat="server"></asp:TextBox>
						    </fieldset>
				        </div>
			        <footer>
                        
				        <div class="submit_link">
					        <asp:Button ID="Submit" runat="server" Text="Update" OnClick="updateButton"/>
				        </div>
			        </footer>
        </article>
    </section>

        <asp:SqlDataSource ID="ArticleListDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:AzureConnString %>" ProviderName="<%$ ConnectionStrings:AzureConnString.ProviderName %>" SelectCommand="SELECT id, Title FROM Posts;"></asp:SqlDataSource>

    </form>

</asp:Content>