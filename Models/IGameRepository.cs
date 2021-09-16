using System.Linq;

namespace cad_games.Models
{
    public interface IGameRepository
    {
        IQueryable<Game> Games { get; }
    }
}