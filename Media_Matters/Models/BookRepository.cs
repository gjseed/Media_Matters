using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;

namespace Media_Matters.Models
{
    public class BookRepository : IBookRepository
    {
        public IEnumerable<Book> getBooks() =>
            new List<Book>
            {
                // the book list
                new Book{ BookTitle="The Lion, The Witch And The Wardrobe", BookISBN=0-06-447104-7, AuthorFname="C. S.", AuthorLname="Lewis",
                    BookEdition= "First Harper Trophy edition", PublishDate= 1994, 
                    BookNotes="It is one of the first books I read, it is also just a nice little adventure", CoverImg="LionWitchWardrobe.jpg"},
                new Book{ BookTitle="Homeland", BookISBN=0-88038-905-2, AuthorFname="R. A.", AuthorLname="Salvatore", 
                    BookEdition= "Unknonwn", PublishDate= 1980, BookNotes="A book with lots of adventure and the good guys winning.", CoverImg="Homeland.jpg"},
                new Book{ BookTitle="The Cat Who Went Into The Closet", BookISBN=0-515-11332-8, AuthorFname="Lillian", 
                    AuthorLname="Jackson Braun", BookEdition= "G. P. Putnam's Sons edition", PublishDate= 1993, 
                    BookNotes="I love cats and what it better than a cat, cat dectectives(although they just help their owner).", CoverImg="thecatwhowentintothecloset.jpg" },
                new Book{ BookTitle="The Eye of the World", BookISBN=0-812-51181-6, AuthorFname="Robert", AuthorLname="Jordan", 
                    BookEdition= "First Mass Market edition", PublishDate= 1190, BookNotes="Epic Adventure, interesting/different magical elements", CoverImg="theeyeoftheworld.jpg" },
                new Book{ BookTitle="Pawn of Prophecy", BookISBN=0-345-30997-9, AuthorFname="David", AuthorLname="Eddings", 
                    BookEdition= "First edition Fourth Printing", PublishDate= 1983, BookNotes="Epic Adventure, interesting/different magical elements" +
                    "and likable characters", CoverImg="pawnofprophecy.jpg" },
            };

        public Book getBookByISBN(double ISBN)
        {
            // getbook by just the isbn number
            return getBooks().FirstOrDefault(p => p.BookISBN == ISBN);
        }
    }
}
