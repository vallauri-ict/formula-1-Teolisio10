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
using FormulaOneWebApiRest.DTOs;
using FormulaOneWebApiRest.Models;

namespace FormulaOneWebApiRest.Controllers
{
    [RoutePrefix("api/Races")]
    public class RacesController : ApiController
    {
        private FormulaOneWebApiRestContext db = new FormulaOneWebApiRestContext();

        // GET: api/Races
        [Route("")]
        public IQueryable<RaceDto> GetRaces()
        {
            return (from r in db.Races
                    select new RaceDto
                    {
                        Id = r.Id,
                        GrandPrixName = r.GrandPrixName,
                        GrandPrixDate = r.GrandPrixDate,
                        NLaps = r.NLaps,
                        CountryName = r.Country.CountryName,
                        CircuitName = r.Circuit.Name
                    }
                );
        }

        // GET: api/Races/5
        [Route("{id:int}")]
        [ResponseType(typeof(RaceDto))]
        public async Task<IHttpActionResult> GetRace(int id)
        {
            var race = await (from r in db.Races
                              where r.Id == id
                              select new RaceDto
                              {
                                  Id = r.Id,
                                  GrandPrixName = r.GrandPrixName,
                                  GrandPrixDate = r.GrandPrixDate,
                                  NLaps = r.NLaps,
                                  CountryName = r.Country.CountryName,
                                  CircuitName = r.Circuit.Name
                              }).FirstOrDefaultAsync();
            if (race == null)
            {
                return NotFound();
            }

            return Ok(race);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RaceExists(int id)
        {
            return db.Races.Count(e => e.Id == id) > 0;
        }
    }
}