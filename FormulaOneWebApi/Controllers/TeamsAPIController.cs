using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FormulaOneDll;

namespace FormulaOneWebApi.Controllers
{
    public class TeamsAPIController : ApiController
    {
        DbTools db = new DbTools();

        public IEnumerable<Team> GetAllTeams()
        {
            return db.GetTeams().Values;
        }

        public IHttpActionResult GetTeams(int id)
        {
            Dictionary<int, Team> d = db.GetTeams();
            var team = d.FirstOrDefault((t) => t.Value.Id == id);
            if (team.Value == null)
                return NotFound();
            return Ok(team.Value);
        }
    }
}
