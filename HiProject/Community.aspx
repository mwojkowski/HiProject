<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Community.aspx.cs" Inherits="HolyInnocents.Community" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
    <!--==========================================GROUPS SECTION========================================-->

          <section class="upcoming-event blog-page single-blog" style="padding-left: 20px;">
      		<div class="container clearfix">
            	<div class="span8 pull-left" id="posts" runat="server">
                    <asp:Literal ID="Clubs" runat="server"></asp:Literal>

                </div>
                       	
                <div class="span4 sidebar pull-right">
                    <div class="tweets">
                    	<h4>Our Staff</h4>
                    	<div class="tweet">
                                
                            <h5><i class="fa fa-twitter"></i>Rev. Joseph Tito</h5>
                            <p>jtito@archchicago.org</p>
                    	</div>
                        <div class="tweet">
                            <h5><i class="fa fa-twitter"></i>Mrs. Lina Ruiz</h5>
                            <p>Relgious Education Coordinator</p>
                            <p>Parish Secretary</p>
                            <p>catequistalina@aol.com</p>
                    	</div>
                        <div class="tweet">
                            <h5><i class="fa fa-twitter"></i>Wojciech Budzyn</h5>
                            <p>Maintenance</p>
                            <p>Polish Liaison</p>
                    	</div>
                        <div class="tweet">
                            <h5><i class="fa fa-twitter"></i>Mr. Michael Seiberlich</h5>
                            <p>Music Director</p>
                    	</div>
                        <div class="tweet">
                            <h5><i class="fa fa-twitter"></i>Mr. Jose Guadalupe Rios</h5>
                            <p>Music Minister</p>
                    	</div>
                        <div class="tweet">
                            <h5><i class="fa fa-twitter"></i>Mrs. Ana Danowska</h5>
                            <p>Music Minister</p>
                    	</div>
                        
                    </div>
                </div>
            
            </div>
      
      </section>


        
    
    
    

    </form>


        
    
    
    

</asp:Content>