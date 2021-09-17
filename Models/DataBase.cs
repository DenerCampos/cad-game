using System.Linq;
using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace cad_games.Models
{
    public class DataBase : IGameRepository
    {
        private string FileName = "data.json";
        private string FilePath = "Models/";

        private string getPath()
        {
            return this.FilePath + this.FileName;
        }

        private List<Game> ReadFile()
        {
            string jsonString = File.ReadAllText(getPath());
            return JsonSerializer.Deserialize<List<Game>>(jsonString);
        }

        private void SaveFile(List<Game> games)
        {
            File.WriteAllText(getPath(), JsonSerializer.Serialize(games));
        }

        private List<Game> GetAll() 
        {
            return ReadFile();
        }

        private Game CreateGame(Game game) 
        {
            List<Game> games = ReadFile();

            int lastId = games.Last().Id;
            lastId++;
            game.Id = lastId;
            games.Add(game);

            SaveFile(games);

            return game;
        }

        private Game DeleteGame(Game game) 
        {
            List<Game> games = ReadFile();

            if (games.Remove(game)) {
                SaveFile(games);
            }

            return game;
        }

        private Game UpdateGame(Game game) 
        {
            List<Game> games = ReadFile();

            var index = games.FindIndex(item => item.Id == game.Id);
            if (index != -1) {
                games[index] = game;
                SaveFile(games);
            }

            return game;
        }

        private Game GetById (int id)
        {
            List<Game> games = ReadFile();
            return games.Find(item => item.Id == id);
        }

        public IQueryable<Game> findAll => GetAll().AsQueryable();

        public Game create(Game game)
        {
            return CreateGame(game);
        }

        public Game delete(Game game)
        {
            return DeleteGame(game);
        }

        public Game update(Game game)
        {
            return UpdateGame(game);
        }

        public Game findByID(int id)
        {

            return new Game();
        }

    }
}