using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolyInnocents
{
    public class Article
    {
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public DateTime date { get; set; }
        public string text { get; set; }

        public Article()
        {
            id = 0;
            this.title = "";
            this.author = "";
            this.date = DateTime.MinValue;
            this.text = "";

        }//close underloaded constructor


        /* Overloaded constructor used for the Article Manager page */
        public Article(int id, string title, string author, DateTime date)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.date = date;

        }//close Article overloaded constructor

        public Article(string title, string author, DateTime date, string text)
        {

            id = 0;
            this.title = title;
            this.author = author;
            this.date = date;
            this.text = text;

        }//close article




    }
}