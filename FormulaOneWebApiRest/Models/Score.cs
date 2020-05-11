using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FormulaOneWebApiRest.Models
{
    public class Score
    {
        [Key]
        public int Id { get; set; }
        public int Points { get; set; }
        public string Details { get; set; }
    }
}