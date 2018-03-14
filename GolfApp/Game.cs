using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfApp
{
    [Table("Game")]
    public class Game
    {
        [Key]
        public int GameId { get; set; }

        [Required]
        public User User { get; set; }
        

        public List<Hole> Holes = new List<Hole>();

        public Game()
        {
            for(int i = 0; i < 18; i++)
            {
                Hole h = new Hole();
                this.Holes.Add(h);
            }
            this.User = new User();
        }

        public static Game GetNewGame()
        {
            Game g = new Game();
            Random rand = new Random();
            g.Holes[0].Par = rand.Next(3, 6);
            g.Holes[1].Par = rand.Next(3, 6);
            g.Holes[2].Par = rand.Next(3, 6);
            g.Holes[3].Par = rand.Next(3, 6);
            g.Holes[4].Par = rand.Next(3, 6);
            g.Holes[5].Par = rand.Next(3, 6);
            g.Holes[6].Par = rand.Next(3, 6);
            g.Holes[7].Par = rand.Next(3, 6);
            g.Holes[8].Par = rand.Next(3, 6);
            g.Holes[9].Par = rand.Next(3, 6);
            g.Holes[10].Par = rand.Next(3, 6);
            g.Holes[11].Par = rand.Next(3, 6);
            g.Holes[12].Par = rand.Next(3, 6);
            g.Holes[13].Par = rand.Next(3, 6);
            g.Holes[14].Par = rand.Next(3, 6);
            g.Holes[15].Par = rand.Next(3, 6);
            g.Holes[16].Par = rand.Next(3, 6);
            g.Holes[17].Par = rand.Next(3, 6);

            return g;
        }

        public List<int> GetListTotalShots()
        {
            List<int> shots = new List<int>();
            foreach (Hole h in Holes)
            {
                shots.Add(h.TotalShots);
            }
            return shots;
        }
    }
}
