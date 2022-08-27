using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMan.ConsoleApp.Models
{
    public class Book
    {
        public int Id = 1;
        public string Authors = "Unknown authors";
        public string Title = "A new book";
        public string Publisher = "Unknown publisher";
        public int Year = 2018;
        public int Edition = 1;
        public string Isbn;
        public string Tags;
        public string Description = "A new book";
        public int Rating = 1;
        public bool Reading = false;
        public string File;
    }
}