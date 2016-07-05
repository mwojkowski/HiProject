<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PhotoGallery.aspx.cs" Inherits="HolyInnocents.PhotoGallery" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
<meta name="viewport" content="user-scalable = yes" />
<meta name="viewport" content="width=device-width, initial-scale=1.0" />

 
 <!--==========================================BOOSTRAPE CSS=============================================-->
<link rel="stylesheet" type="text/css" href="Content/bootstrap-combined.min.css"/>    
<link rel="stylesheet" type="text/css" href="Content/bootstrap.css"/>
<link rel="stylesheet" type="text/css" href="Content/bootstrap-responsive.css"/>


 <!--==========================================FONT AWOSOME=============================================-->
<link rel="stylesheet" type="text/css" href="Content/font-awesome.css"/>
<link rel="stylesheet" type="text/css" href="Content/font-awesome.min.css"/>

 <!--==========================================CUSTOM CSS=============================================-->
<link rel="stylesheet" type="text/css" href="Content/style.css"/>
<link rel="stylesheet" type="text/css" href="Content/color.css"/>
<link rel="stylesheet" type="text/css" href="Content/reset.css"/>




<!--==========================================GOOGLE FONTS=============================================-->
<link href='http://fonts.googleapis.com/css?family=Roboto:900,400' rel='stylesheet' type='text/css'>
<link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css'>
<link href='http://fonts.googleapis.com/css?family=Roboto:400,700,800,900' rel='stylesheet' type='text/css'>
<link href='http://fonts.googleapis.com/css?family=Raleway:400,700,800' rel='stylesheet' type='text/css'>
 

    <section class="gallery-two gallery-res three-gallery">
      		<div class="container clearfix">
            	<div class="pull-left">
                  	<asp:Literal ID="GalleryImages" runat="server"></asp:Literal>
                    
                     <%-- %><div class="pagination clearfix">
                     	<ul>
                        	<li><i class="fa fa-angle-double-left"></i></li>
                            <li>1</li>
                            <li>2</li>
                            <li>3</li>
                            <li><i class="fa fa-angle-double-right"></i></li>
                        
                        </ul>
                     
                     </div>      --%>      
                </div>        	
                
            
            </div>
      
      </section>


   		 <script src="js/jquery.js" type="text/javascript" charset="utf-8"></script> 
		
		 <!--==========================================FANCY BOX JS=============================================-->
        <script type="text/javascript" src="js/jquery.fancybox.pack.js?v=2.1.5"></script>
        <script type="text/javascript" src="js/custom.js"></script>	
		
		 <!--==========================================BOOSTRAP JS=============================================-->
		<script type="text/javascript" src="js/bootstrap.min.js"></script>
		<script type="text/javascript" src="js/bootstrap.js"></script>
        
		<!--==========================================sticky navbar js=============================================-->
		<script type="text/javascript" src="js/sticky.js"></script>
      
       <script type="text/javascript" src="js/cbpQTRotator.min.js"></script>
       <script type="text/javascript" src="js/mypassion.js"></script> 
</asp:Content>
