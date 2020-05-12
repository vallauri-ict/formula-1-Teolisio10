using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FormulaOneWebApiRest.DTOs
{
    public class RankingDto
    {
        [Key]
        public int Id { get; set; }

        public string DriverFirstname { get; set; }
        public string DriverLastname { get; set; }

        public string CountryCode{ get; set; }

        public string TeamName { get; set; }

        public string Points { get; set; }
    }
}