<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HolyInnocents._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
	  <!--===========================================main slider==============================================-->
    <div class="flicker-example" data-block-text="false">
        
            <ul>
			
			    <li data-background="images/slider1.jpg">
				    <div class="flick-title">Holy Innocents Church</div>
				    <div class="flick-h2"><h3>A tri-lingual Chicago Catholic Community</h3></div>
				
			    </li>
                <li data-background="images/slider2.jpg">
				    <div class="flick-title">Community</div>
				    <div class="flick-h2"><h3></h3></div>
			    </li>
                <li data-background="images/slider3.jpg">
				    <div class="flick-title">A Place of Worship for All</div>
				    <%--<div class="flick-h2"><h3>Lorem ipsum dolor sit amet consecte tur adipiscing
    titor diam, a accumsan justo laoreet.</h3></div>--%>
			    </li>
			
			
			
		    </ul>

		
	</div>
	
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

          <section class="upcoming-event blog-page single-blog" >
      		<div class="container clearfix">
            	<div class="span8 pull-left" style="width: 67%; padding-left:10px;">
                                
                    <asp:Literal ID="BlogPosts" runat="server"></asp:Literal>
                </div>
                       	
                  

       <!--==========================================SIDE SECTION========================================-->
                <div class="span4 sidebar pull-right" style="width: 25%;">
                <div class="tweets" style="padding-bottom: 10px;">
                    <h4>Upcoming Events</h4>
                    <iframe src="https://calendar.google.com/calendar/embed?mode=AGENDA&amp;height=600&amp;wkst=1&amp;bgcolor=%23FFFFFF&amp;src=holyinnocentschicago%40gmail.com&amp;color=%23711616&amp;ctz=America%2FChicago" style="border-width:0" width="100%" height="400" frameborder="0" scrolling="no"></iframe>
                </div>
                <div class="tweets">
                    	<h4>Latest Bulletins</h4>
                        <asp:Literal ID="BulletinColumn" runat="server"></asp:Literal>
                    </div>
                </div>
            </div>

      
      </section>

    
    
    
    
    
    
    

</asp:Content>
