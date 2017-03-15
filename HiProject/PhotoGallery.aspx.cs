using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HolyInnocents
{
    public partial class PhotoGallery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            populategallery();
        }//close page_load

        private void populategallery()
        {
            string[] filesindirectory = Directory.GetFiles(Server.MapPath("~/Images/Gallery/"));
            List<String> images = new List<string>(filesindirectory.Count());

            foreach (string item in filesindirectory)
            {
                images.Add(String.Format(System.IO.Path.GetFileName(item)));
            }//close foreach loop

            GalleryImages.Text = "";
            for (int x = 0; x < images.Count; x++)
            {
                GalleryImages.Text = GalleryImages.Text +
                    "<div class=\"span4 gri\">" +
                    "<figure class=\"effect-layla\">" +
                    "<img src=\"../images/Gallery/" + images[x] + "\" alt=\"galeryimg\">" +
                    "<a class=\"fancybox\" href=\"" + "" + "\"  title=\"Enlarge\">VIEW</a>" +
                    "</figure></div>";

            }//close for loop

        }//close populategallery()

    }//close class
}//close namespace

