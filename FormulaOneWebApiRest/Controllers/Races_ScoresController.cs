using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using FormulaOneWebApiRest.Data;
using FormulaOneWebApiRest.Models;

namespace FormulaOneWebApiRest.Controllers
{
    public class Races_ScoresController : ApiController
    {
        private FormulaOneWebApiRestContext db = new FormulaOneWebApiRestContext();

        // GET: api/Races_Scores
        public IQueryable<Races_Scores> GetRaces_Scores()
        {
            return db.Races_Scores;
        }

        // GET: api/Races_Scores/5
        [ResponseType(typeof(Races_Scores))]
        public async Task<IHttpActionResult> GetRaces_Scores(int id)
        {
            Races_Scores races_Scores = await db.Races_Scores.FindAsync(id);
            if (races_Scores == null)
            {
                return NotFound();
            }

            return Ok(races_Scores);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Races_ScoresExists(int id)
        {
            return db.Races_Scores.Count(e => e.Id == id) > 0;
        }
    }
}