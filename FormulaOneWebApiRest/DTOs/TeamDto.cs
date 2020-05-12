using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FormulaOneWebApiRest.Models;

namespace FormulaOneWebApiRest.DTOs
{
    public class TeamDto
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        
        public string FirstDriverFirstname { get; set; }
        public string FirstDriverLastname { get; set; }
        public string SecondDriverFirstname { get; set; }
        public string SecondDriverLastname { get; set; }
    }
}