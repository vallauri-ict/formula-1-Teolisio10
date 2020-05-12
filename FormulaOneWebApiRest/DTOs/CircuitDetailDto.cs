using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FormulaOneWebApiRest.DTOs
{
    public class CircuitDetailDto
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Length { get; set; }
        public string RecordLap { get; set; }
        public string Img { get; set; }
        public int FirstGrandPrix { get; set; }

        public string CountryName { get; set; }

        public DateTime RaceGrandPrixDate { get; set; }
        public string RaceGrandPrixName{ get; set; }
        public int RaceNLaps{ get; set; }
    }
}