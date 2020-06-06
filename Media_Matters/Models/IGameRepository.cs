using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Media_Matters.Models
{
    public interface IGameRepository
    {
        IEnumerable<Game> getGames();
        Game getGamebyId(int Id);
    }
}