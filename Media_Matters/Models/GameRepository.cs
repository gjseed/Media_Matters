using System.Collections.Generic;
using System.Linq;

namespace Media_Matters.Models
{
    public class GameRepository : IGameRepository
    {
        public IEnumerable<Game> getGames() =>
            new List<Game>
            {
                // the Game list
                new Game{ GameId=1, GameTitle="Fallout New Vegas",
                    Notes="Compelling story and fun game even with all the glitches.", GameCover="FNV_box_art.jpg" },
                new Game{ GameId=2, GameTitle="Dishonored Series",
                    Notes="Gameplay allows for so many different choices.", GameCover="Dishonored2.jpg" },
                new Game{ GameId=3, GameTitle="Skyrim",
                    Notes="After 9 years and 1,163 hours of gameplay I still don't think I have seen everything.",
                    GameCover="skyrim.jpg" },
                new Game{ GameId=4, GameTitle="Kingdoms of Amalur: Reckoning",
                    Notes="You don't have to choose between melee/longdistance/magic styles of fighting, you can do all of them" +
                    "with a quck switch.",
                    GameCover="Kingdoms_of_Amalur_Reckoning_cover.png" },
                new Game{ GameId=5, GameTitle="The Sims Medieval",
                    Notes="Fun little quests in a medieval setting.", GameCover="Pirates_and_Nobles_Cover_Art.jpg" },
            };
        public Game getGamebyId(int Id)
        {
            return getGames().FirstOrDefault(p => p.GameId == Id);
        }
    }
}
