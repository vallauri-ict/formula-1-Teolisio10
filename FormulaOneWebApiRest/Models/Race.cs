using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FormulaOneWebApiRest.Models
{
    public class Race
    {
        [Key]
        public int Id { get; set; }
        public string GrandPrixName { get; set; }
        public int NLaps { get; set; }
        public DateTime GrandPrixDate { get; set; }

        public string ExtCountry { get; set; }
        [ForeignKey("ExtCountry")]
        public Country Country { get; set; }

        public int ExtCircuit { get; set; }
        [ForeignKey("ExtCircuit")]
        public Circuit Circuit { get; set; }
    }
}