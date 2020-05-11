using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FormulaOneWebApiRest.Data
{
    public class FormulaOneWebApiRestContext : DbContext
    {
        // ASSEGNIAMO IL NOSTRO DATABASE
        // PER MODIFICARE CONTROLLARE ANCHE Web.config
        public FormulaOneWebApiRestContext() : base("name=FormulaOne")
        {
        }

        public System.Data.Entity.DbSet<FormulaOneWebApiRest.Models.Circuit> Circuits { get; set; }

        public System.Data.Entity.DbSet<FormulaOneWebApiRest.Models.Country> Countries { get; set; }

        public System.Data.Entity.DbSet<FormulaOneWebApiRest.Models.Score> Scores { get; set; }

        public System.Data.Entity.DbSet<FormulaOneWebApiRest.Models.Race> Races { get; set; }

        public System.Data.Entity.DbSet<FormulaOneWebApiRest.Models.Driver> Drivers { get; set; }

        public System.Data.Entity.DbSet<FormulaOneWebApiRest.Models.Team> Teams { get; set; }

        public System.Data.Entity.DbSet<FormulaOneWebApiRest.Models.Races_Scores> Races_Scores { get; set; }
    }
}
