using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FormulaOneWebApiRest.Models
{
    public class Races_Scores
    {
        [Key]
        public int Id { get; set; }
        public string FastestLap { get; set; }

        public int ExtDriver { get; set; }
        [ForeignKey("ExtDriver")]
        public Driver Driver { get; set; }

        public int ExtScore { get; set; }
        [ForeignKey("ExtScore")]
        public Score Score { get; set; }

        public int ExtRace { get; set; }
        [ForeignKey("ExtRace")]
        public Race Race { get; set; }
    }
}