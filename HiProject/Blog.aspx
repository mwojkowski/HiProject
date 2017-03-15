<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Blog.aspx.cs" Inherits="HolyInnocents.Blog" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
	  <!--===========================================main slider==============================================-->

	
	 <%-- %><!--===========================================time counter section==============================================--> 
     <section class="time-counter clearfix">
     		<div class="container">
                <div class="upcoming pull-left clearfix">
                    <div class="all-events pull-left" style="padding-left: 20px;">
                    	<h3>UPCOMING EVENT</h3>
                        <h3 class="school">Event Name</h3>
                        <a href="#">More Information<span><i class="fa fa-long-arrow-right"></i></span></a>
                    </div>
                </div>
                <div class="timecount pull-right">
                 <div id="counter">
                        </div>
                </div>
     		</div>
     </section>
     

        <!--==========================================Posts SECTION========================================-->--%>

          <section class="contactus" style="padding-left: 20px;">
      		<div class="container clearfix">
            	<div class="span8 pull-left">
                                
                    <asp:Literal ID="BlogPosts" runat="server"></asp:Literal>
                </div>
                       	
                  </div>

       <!--==========================================TWITTER SECTION========================================-->
                <div class="span4 sidebar pull-right">
                <%--    <div class="tweets">
                    	<h4>Tweet Widget</h4>
                    	<div class="tweet">
                                
                                <h5><i class="fa fa-twitter"></i>John Doe</h5>
                                <p>Lorem ipsum dolor sit amet, consectetur adipis cing
        elit. Curabitur ut blandit. <span><a href="">http://t.co/hd3sk</a></span></p>
                                <p>2 days ago</p>
                    	</div>
                        <div class="tweet">
                                
                                <h5><i class="fa fa-twitter"></i>John Doe</h5>
                                <p>Lorem ipsum dolor sit amet, consectetur adipis cing
        elit. Curabitur ut blandit. <span><a href="">http://t.co/hd3sk</a></span></p>
                                <p>2 days ago</p>
                    	</div>
                        
                    </div>
                </div>--%>
            
            </div>
      
      </section>

    
    
    
    
    
    
    

</asp:Content>
