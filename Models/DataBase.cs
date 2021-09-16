using System.Linq;
using System;
using System.IO;
using System.Text.Json;

namespace cad_games.Models
{
    public class DataBase : IGameRepository
    {
        public string FileName = "data.json";
        public string FilePath = "";

        private static Game[] Data = new Game[] {
            new Game { Id = 1, Name = "Demons Souls", Finished = true, Date = "2018-06-07" },
            new Game { Id = 2, Name = "Dark Souls", Finished = true, Date = "2019-06-07" },
            new Game { Id = 3, Name = "Dark Souls 2", Finished = true, Date = "2020-06-07" },
            new Game { Id = 4, Name = "Dark Souls 3", Finished = true, Date = "2021-06-07" },
        };


        public IQueryable<Game> Games => Data.AsQueryable();
    }
}