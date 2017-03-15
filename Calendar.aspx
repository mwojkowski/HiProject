<%@ Page Language="C#"  MasterPageFile="~/Site.Master"  AutoEventWireup="true" CodeBehind="Calendar.aspx.cs" Inherits="HolyInnocents.Calendar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-heading text-center">

        <div class="container zoomIn animated">

            <h1 class="page-title">Parish Calendar<span class="title-under"></span></h1>

        </div>

    </div>

    <div class="section-home about-us fadeIn animated">

        <div class="container">

            <div class="row">

                <div class="col-md-7 col-sm-12 col-form">

                    <div class="calendar-container">
                        <iframe src="https://calendar.google.com/calendar/embed?showTitle=0&amp;showPrint=0&amp;showTabs=0&amp;showCalendars=0&amp;height=750&amp;wkst=1&amp;bgcolor=%23FFFFFF&amp;src=holyinnocentschicago%40gmail.com&amp;color=%23A32929&amp;ctz=America%2FChicago" style="border-width:0" width="1250" height="750" frameborder="0" scrolling="no"></iframe>

                    </div>


                </div>
                <div class="col-md-4 col-md-offset-1 col-contact">



                </div>


            </div>

        </div>

    </div> <!-- /.about-us -->

</asp:Content>

