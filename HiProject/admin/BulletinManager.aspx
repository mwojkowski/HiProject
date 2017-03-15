<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminPanel.Master" AutoEventWireup="true" CodeBehind="BulletinManager.aspx.cs" Inherits="HolyInnocents.admin.BulletinManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <section id="main" class="column">

            <asp:Literal ID="messageLiteral" runat="server"></asp:Literal>


            <article class="module width_3_quarter">
                <header>
                    <h3 class="tabs_involved">Existing Files</h3>
                </header>

                <div class="tab_container">
                    <table style="width:100%">
                        
                        <tr>
                            <th>Date</th>
                            <th>File</th>
                        </tr>
                        <asp:Literal ID="bulletinTable" runat="server">


                        </asp:Literal>
                    </table>

                </div>
                <!-- end of .tab_container -->

            </article>
            <!-- end of content manager article -->

            <article class="module width_quarter">
                <header>
                    <h3>Upload File</h3>
                </header>
                <div class="message_list">
                    <div class="module_content">
                        <table>
                            <tr>
                                <td>Date: </td>
                                <td><asp:TextBox ID="DateTextBox" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>File: </td>
                                <td><asp:FileUpload ID="FileUpload1" runat="server" /></td>
                            </tr>
                        </table>

                        
                    </div>
                </div>
                <footer>
                    <div class="post_message">
                        <asp:Button ID="Submit" runat="server" Text="Upload" OnClick="uploadButton"/>
                    </div>
                </footer>
            </article>
            <!-- end of messages article -->

        </section>

        

    </form>
</asp:Content>
