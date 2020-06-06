using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Media_Matters.Models
{
    public class Book
    {
        public string BookTitle { get; set; }
        public double BookISBN { get; set; }
        public string AuthorFname { get; set; }
        public string AuthorLname { get; set; }
        public string BookEdition { get; set; }
        public int PublishDate { get; set; }
        public string CoverImg { get; set; }
        public string BookNotes { get; set; }
    }
}
