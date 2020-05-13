using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FormulaOneWebApiRest.DTOs
{
    public class RaceDto
    {
        [Key]
        public int Id { get; set; }
        public string GrandPrixName { get; set; }
        public int NLaps { get; set; }
        public DateTime GrandPrixDate { get; set; }

        public string CountryName { get; set; }

        public string CircuitName { get; set; }
    }
}