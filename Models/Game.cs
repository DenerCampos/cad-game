
namespace cad_games.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Finished { get; set; }
        public string Date { get; set; }

        public Game (string name=null, bool finished=false, string date=null)
        {
            this.Name = name;
            this.Finished = finished;
            this.Date = date;
        } 
    }
}
