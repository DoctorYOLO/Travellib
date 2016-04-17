using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Travel_Lib2.Models
{
    public class BookDetailsDTO
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string BookImage { get; set; }
    }
}