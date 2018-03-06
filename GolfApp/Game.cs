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
    }
}
