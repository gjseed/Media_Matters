using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Media_Matters.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public string GameTitle { get; set; }
        public string GameCover { get; set; }
        public string Notes { get; set; }
    }
}
