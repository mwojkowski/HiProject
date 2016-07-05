<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="HolyInnocents.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
	  
	
     

        <!--==========================================CONTACT FORM SECTION========================================-->

          <section class="upcoming-event blog-page single-blog" style="padding-left: 20px;">
             <%-- <a href="Contact.aspx.cs">Contact.aspx.cs</a>--%>
      		<div class="container clearfix">
            	<div class="span8 pull-left">
                    <asp:Literal ID="messageLiteral" runat="server"></asp:Literal>
                    <form id="form1" runat="server">
                        <table id="table" style="padding-left:25px; width:90%;">
                             <tr>
                                <td style="width:25%; padding-left: 25px;"><asp:Label ID="NameLabel" runat="server" Text="Name*: "></asp:Label></td>
                                <td style="width:75%; padding-left: 25px;"><asp:TextBox ID="txtName" runat="server" Width="235px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td style="width:25%; padding-left: 25px;"><asp:Label ID="EmailLabel" runat="server" Text="Email: "></asp:Label></td>
                                <td style="width:75%; padding-left: 25px;"><asp:TextBox ID="txtEmail" runat="server" Width="233px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td style="width:25%; padding-left: 25px;"><asp:Label ID="SubjectLabel" runat="server" Text="Subject: "></asp:Label></td>
                                <td style="width:75%; padding-left: 25px;"><asp:TextBox ID="txtSubject" runat="server" Width="409px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td style="width:25%; padding-left: 25px;"><asp:Label ID="MessageLabel" runat="server" Text="Message: "></asp:Label></td>
                                <td style="width:75%; padding-left: 25px;"><asp:TextBox ID="txtMessage" TextMode="MultiLine" Rows="15" runat="server" Width="416px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:Button ID="ContactButton" runat="server" Text="Submit" OnClick="SubmitButton" />

                                </td>

                            </tr>
                        </table>
                    </form>
                    You may email us anytime at holyinnocentschicago@gmail.com.
                </div>
                       	


       <!--==========================================TWITTER SECTION========================================-->
                <div class="span4 sidebar pull-right">
                   <div class="tweets">
                    	<h4>Rectory Hours</h4>
                    	<div class="tweet">
                                
                                <h5>Hours</h5>
                                <p>Monday-Thursday: 9:00 am to 5:00 pm</p>
                                <p>Friday: By Appointment</p>
                    	</div>
                        <div class="tweet">
                                
                                <h5>Phone</h5>
                                <p>(312) 666-3675</p>
                       	</div>
                        <div class="tweet">
                                
                                <h5>Fax</h5>
                                <p>(312) 666-0714</p>
                       	</div>
                        
                    </div>
                </div>
            
            </div>
      
      </section>

    
    
    
    
    
    
    

</asp:Content>

