using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Media_Matters.Models;
using Microsoft.AspNetCore.Mvc;

namespace Media_Matters.Controllers
{
    public class AlbumsController : Controller
    {
        private readonly IAlbumRepository ar;
        public AlbumsController(IAlbumRepository AlbumRepo)
        {
            ar = AlbumRepo;
        }

        public IActionResult Albums()
        {
            return View(ar.getAlbums());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
