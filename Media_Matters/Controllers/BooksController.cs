using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Media_Matters.Models;
using System.Diagnostics;

namespace Media_Matters.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookRepository br;
        public BooksController(IBookRepository BookRepo)
        {
            br = BookRepo;
        }

        public IActionResult Books()
        {
            return View(br.getBooks());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
