using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FormulaOneWebApiRest.DTOs
{
    public class RacesResultsDetailDto
    {
        [Key]
        public int Id { get; set; }
        public string FastestLap { get; set; }

        public int RacesNLaps { get; set; }

        public string DriverFirstname { get; set; }
        public string DriverLastname { get; set; }
        public int DriverNumber { get; set; }

        public int ScoreId { get; set; }
        public int ScorePoints { get; set; }
    }
}