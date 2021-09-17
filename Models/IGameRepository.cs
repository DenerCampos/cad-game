using System.Linq;

namespace cad_games.Models
{
    public interface IGameRepository
    {
        IQueryable<Game> findAll { get; }

        Game create(Game game);

        Game delete(Game game);

        Game update(Game game);

        Game findByID(int id);
    }
}