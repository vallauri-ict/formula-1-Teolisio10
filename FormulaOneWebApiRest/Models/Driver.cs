using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FormulaOneWebApiRest.Models
{
    public class Driver
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Dob { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Image { get; set; }

        public string ExtCountry { get; set; }
        [ForeignKey("ExtCountry")]
        public Country Country { get; set; }
    }
}