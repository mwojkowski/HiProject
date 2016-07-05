using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolyInnocents
{
    public class Article
    {
        public string title { get; set; }
        public string author { get; set; }
        public DateTime date { get; set; }
        public string text { get; set; }

        public Article()
        {
            this.title = "";
            this.author = "";
            this.date = DateTime.MinValue;
            this.text = "";

        }//close underloaded constructor



        public Article(string title, string author, DateTime date, string text)
        {


            this.title = title;
            this.author = author;
            this.date = date;
            this.text = text;

        }//close article




    }
}