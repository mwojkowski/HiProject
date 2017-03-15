/*
 * 
 * Created by Matthew Wojkowski on 2/25/2017
 * Purpose: Allows of multiple languages for the website
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolyInnocents.App_Code
{
    public class clsLanguageSelector
    {
        public clsLink link1 { get; set; }
        public clsLink link2 { get; set; }
        public clsLink link3 { get; set; }
        public clsLink link4 { get; set; }
        public clsLink link5 { get; set; }

        public LanguageString slider1 { get; set; }
        public LanguageString slider1Text { get; set; }
        public LanguageString slider2{ get; set; }
        public LanguageString slider3 { get; set; }

        public LanguageString pageTitle { get; set; }//Primary pane title
        public LanguageString pageText { get; set; }//Primary pane text
        public LanguageString sideTitle { get; set; }//Secondary pane title
        public LanguageString sideText { get; set; }//Secondary pane text

        public LanguageString fAboutUsTitle { get; set; }
        public LanguageString fAboutUsText { get; set; }

        public LanguageString fLinksLike { get; set; }
        public clsLink fLink1 { get; set; }
        public clsLink fLink2 { get; set; }
        public clsLink fLink3 { get; set; }

        public LanguageString fEmailListTitle { get; set; }



    }//close class
}//close namespace