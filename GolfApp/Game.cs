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
        public int Hole1 { get; set; }
        public int Game2 { get; set; }
        public int Game3 { get; set; }
        public int Game4 { get; set; }
        public int Game5 { get; set; }
        public int Game6 { get; set; }
        public int Game7 { get; set; }
        public int Game8 { get; set; }
        public int Game9 { get; set; }
        public int Game10 { get; set; }
        public int Game11 { get; set; }
        public int Game12 { get; set; }
        public int Game13 { get; set; }
        public int Game14 { get; set; }
        public int Game15 { get; set; }
        public int Game16 { get; set; }
        public int Game17 { get; set; }
        public int Game18 { get; set; }
        public int? currHole { get; set; }

        public Game()
        {

        }
    }
}
