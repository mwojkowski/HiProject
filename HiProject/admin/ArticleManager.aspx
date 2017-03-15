<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminPanel.Master" AutoEventWireup="true" CodeBehind="ArticleManager.aspx.cs" Inherits="HolyInnocents.admin.ArticleManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">
    <section id="main" class="column">

        <asp:Literal ID="messageLiteral" runat="server"></asp:Literal>


        <article class="module width_full">
             <header><h3 class="tabs_involved">Content Manager</h3>
		    </header>

		    <div class="tab_container">
			    <div id="tab1" class="tab_content">
			    <table class="tablesorter" cellspacing="0"> 
			    <thead> 
				    <tr> 
    				    <th>Article Title</th> 
    				    <th>Date Created</th> 
    				    <th>Actions</th> 
				    </tr> 
			    </thead> 
			    <tbody>

                 <asp:Literal ID="newsArticles" runat="server"></asp:Literal>
				    <tr> 
    				    <td>Lorem Ipsum Dolor Sit Amet</td> 
    				    <td>Articles</td> 
    				    <td><input type="image" src="images/icn_edit.png" title="Edit"><input type="image" src="images/icn_trash.png" title="Trash"></td> 
				    </tr> 
			    </tbody> 
			    </table>
			    </div><!-- end of #tab1 -->
			
		    </div><!-- end of .tab_container -->
		

        </article>
    </section>

    </form>


</asp:Content>
