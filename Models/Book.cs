using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMan.ConsoleApp.Models
{
    public class Book
    {
        public int Id { get; set; } = 1;
        public string Authors { get; set; } = "Unknown author";
        public string Title { get; set; } = "A new book";
        public string Publisher { get; set; } = "Unknown publisher";
        public int Year { get; set; } = 2018;
        public int Edition { get; set; } = 1;
        public string Isbn { get; set; }
        public string Tags { get; set; }
        public string Description { get; set; } = "A new book";
        public int Rating { get; set; } = 1;
        public bool Reading { get; set; }
        public string File { get; set; }
    }
}