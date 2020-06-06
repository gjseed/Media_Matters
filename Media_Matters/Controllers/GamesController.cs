using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Media_Matters.Models;
using Microsoft.AspNetCore.Mvc;

namespace Media_Matters.Controllers
{
    public class GamesController : Controller
    {
        private readonly IGameRepository gr;
        public GamesController(IGameRepository GameRepo)
        {
            gr = GameRepo;
        }

        public IActionResult Games()
        {
            return View(gr.getGames());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
