using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FormulaOneWebApiRest.DTOs
{
    public class TeamDetailDto
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string FullTeamName { get; set; }
        public string PowerUnit { get; set; }
        public string TechnicalChief { get; set; }
        public string Chassis { get; set; }

        public string FirstDriverFirstname { get; set; }
        public string FirstDriverLastname { get; set; }
        public int FirstDriverNumber { get; set; }
        public string FirstDriverImage { get; set; }
        public string SecondDriverFirstname { get; set; }
        public string SecondDriverLastname { get; set; }
        public int SecondDriverNumber { get; set; }
        public string SecondDriverImage { get; set; }
    }
}