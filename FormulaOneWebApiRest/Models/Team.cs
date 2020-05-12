using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FormulaOneWebApiRest.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string FullTeamName { get; set; }
        public string PowerUnit { get; set; }
        public string TechnicalChief { get; set; }
        public string Chassis { get; set; }

        public string ExtCountry { get; set; }
        [ForeignKey("ExtCountry")]
        public Country Country { get; set; }

        public int ExtFirstDriver { get; set; }
        [ForeignKey("ExtFirstDriver")]
        public Driver Driver1 { get; set; }

        public int ExtSecondDriver { get; set; }
        [ForeignKey("ExtSecondDriver")]
        public Driver Driver2 { get; set; }
    }
}