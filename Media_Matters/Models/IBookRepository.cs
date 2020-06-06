using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Media_Matters.Models
{
    public interface IBookRepository
    {
        IEnumerable<Book> getBooks();
        Book getBookByISBN(double ISBN);
    }
}
