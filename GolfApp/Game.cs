using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfApp
{
    [Table("Games")]
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        [Required]
        public List<Hole> Holes { get; set; }
        public int? currHole { get; set; }

        public Game()
        {

        }
    }
}
