using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FormulaOneWebApiRest.Models
{
    public class Circuit
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Length { get; set; }
        public string RecordLap { get; set; }
        public string Img { get; set; }
        public int FirstGrandPrix { get; set; }
    }
}