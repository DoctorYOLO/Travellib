using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Travel_Lib2.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string BookImage { get; set; }
        public string Year { get; set; }
        public string ISBN { get; set; }
        public string Cover { get; set; }
        public string Language { get; set; }
        public string Pages { get; set; } 
    }
}