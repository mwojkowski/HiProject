<%@ Page Language="C#" MasterPageFile="~/admin/AdminPanel.Master" ValidateRequest="False" AutoEventWireup="true" CodeBehind="NewArticle.aspx.cs" Inherits="HolyInnocents.NewArticle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <section id="main" class="column">

        <asp:Literal ID="messageLiteral" runat="server"></asp:Literal>


        <article class="module width_full">
			        <header><h3>Post New Article</h3></header>
				        <div class="module_content">
						        <fieldset>
							        <label>Post Title</label>
							        <asp:TextBox ID="txtPostTitle" runat="server"></asp:TextBox>
						        </fieldset>
						        <fieldset>
							        <label>Content</label>
							        <asp:TextBox ID="txtArticleBody" TextMode="MultiLine" Rows="15" runat="server"></asp:TextBox>
						        </fieldset>
				        </div>
			        <footer>
				        <div class="submit_link">
					        <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="SubmitButton"/>
				        </div>
			        </footer>
        </article>
    </section>

    </form>

</asp:Content>