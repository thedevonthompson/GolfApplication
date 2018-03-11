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
        public User UserId { get; set; }
        public Hole Hole1 { get; set; }
        public Hole Hole2 { get; set; }
        public Hole Hole3 { get; set; }
        public Hole Hole4 { get; set; }
        public Hole Hole5 { get; set; }
        public Hole Hole6 { get; set; }
        public Hole Hole7 { get; set; }
        public Hole Hole8 { get; set; }
        public Hole Hole9 { get; set; }
        public Hole Hole10 { get; set; }
        public Hole Hole11 { get; set; }
        public Hole Hole12 { get; set; }
        public Hole Hole13 { get; set; }
        public Hole Hole14 { get; set; }
        public Hole Hole15 { get; set; }
        public Hole Hole16 { get; set; }
        public Hole Hole17 { get; set; }
        public Hole Hole18 { get; set; }
        public int? currHole { get; set; }

        public Game()
        {

        }

        public static Game GetNewGame()
        {
            Game g = new Game();
            Random rand = new Random();
            g.Hole1.Par = rand.Next(3, 6);
            g.Hole2.Par = rand.Next(3, 6);
            g.Hole3.Par = rand.Next(3, 6);
            g.Hole4.Par = rand.Next(3, 6);
            g.Hole5.Par = rand.Next(3, 6);
            g.Hole6.Par = rand.Next(3, 6);
            g.Hole7.Par = rand.Next(3, 6);
            g.Hole7.Par = rand.Next(3, 6);
            g.Hole8.Par = rand.Next(3, 6);
            g.Hole9.Par = rand.Next(3, 6);
            g.Hole10.Par = rand.Next(3, 6);
            g.Hole11.Par = rand.Next(3, 6);
            g.Hole12.Par = rand.Next(3, 6);
            g.Hole13.Par = rand.Next(3, 6);
            g.Hole14.Par = rand.Next(3, 6);
            g.Hole15.Par = rand.Next(3, 6);
            g.Hole16.Par = rand.Next(3, 6);
            g.Hole17.Par = rand.Next(3, 6);
            g.Hole18.Par = rand.Next(3, 6);

            return g;
        }
    }
}
