<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Community.aspx.cs" Inherits="HolyInnocents.Community" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
    <!--==========================================GROUPS SECTION========================================-->
        <div class="page-heading text-center">

    <div class="container zoomIn animated">

        <h1 class="page-title">Our Communities<span class="title-under"></span></h1>


    </div>

</div>


<div class="section-home about-us fadeIn animated">

    <div class="container">

        <div class="row">

            <div class="col-md-7 col-sm-12 col-form">
                <asp:Literal ID="Clubs" runat="server"></asp:Literal>
                


            </div>
            <div class="col-md-4 col-md-offset-1 col-contact">

                <h2 class="title-style-2">Our Staff<span class="title-under"></span></h2>

                <div>
                    <h5><b>Juan Carlos Arrieta Correa</b></h5>
                    <p style="padding-left:10px">Pastor</p>
                </div>
                <hr />
                <div class="tweet">
                    <h5><b>Mrs. Lina Ruiz</b></h5>
                    <p style="padding-left:10px">Religious Education Coordinator</p>
                    <p style="padding-left:10px">catequistalina@aol.com</p>
                </div>
                <hr />
                <div>
                    <h5><b>Wojciech Budzyn</b></h5>
                    <p style="padding-left:10px">Maintenance</p>
                    <p style="padding-left:10px">Polish Liaison</p>
                </div>
                <hr />
                <div>
                    <h5><b>Mr. Michael Seiberlich</b></h5>
                    <p style="padding-left:10px">Music Director</p>
                </div>
                <hr />
                <div>
                    <h5><b>Mr. Jose Guadalupe Rios</b></h5>
                    <p style="padding-left:10px">Music Minister</p>
                </div>
                <hr />
                <div>
                    <h5><b>Mrs. Ana Danowska</b></h5>
                    <p style="padding-left:10px">Music Minister</p>
                </div>
                <hr />

            </div>


        </div>

    </div>

</div> <!-- /.about-us -->


        
    
    
    

    </form>


        
    
    
    

</asp:Content>