using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfApp
{
    [Table("Holes")]
    public class Hole
    {
        [Key]
        public int HoleId { get; set; }

        public int HoleNum { get; set; }

        public int TotalShots { get; set; }

        public string DriveType { get; set; }

        public bool OnFairway { get; set; }

        public bool InRegulation { get; set; }

        public int Par { get; set; }

        public int NumPutts { get; set; }

    }
}
