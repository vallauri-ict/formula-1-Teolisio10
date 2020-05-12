using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FormulaOneWebApiRest.DTOs
{
    public class RacesResultDto
    {
        [Key]
        public int Id { get; set; }
        public string FastestLap { get; set; }

        public string DriverFirstname { get; set; }
        public string DriverLastname { get; set; }

        public int RaceNLaps { get; set; }
        public DateTime RaceGrandPrixDate { get; set; }

        public string CountryName { get; set; }
    }
}