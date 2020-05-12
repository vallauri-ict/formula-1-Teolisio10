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
using System.Linq.Expressions;
using FormulaOneWebApiRest.DTOs;
using System.Web.Routing;

namespace FormulaOneWebApiRest.Controllers
{
    [RoutePrefix("api/Circuits")]
    public class CircuitsController : ApiController
    {
        private FormulaOneWebApiRestContext db = new FormulaOneWebApiRestContext();

        // GET: api/Circuits
        [Route("")]
        public IQueryable<CircuitDto> GetCircuits()
        {
            return (from c in db.Circuits
                    from r in db.Races
                    where c.Id == r.ExtCircuit
                    select new CircuitDto
                    {
                        Id = c.Id,
                        Name = c.Name,
                        Img = c.Img,
                        CountryName = r.ExtCountry
                    }
                );
        }

        // GET: api/Circuits/5
        [Route("{id:int}")]
        [ResponseType(typeof(CircuitDto))]
        public async Task<IHttpActionResult> GetCircuit(int id)
        {
            var circuit = await (from c in db.Circuits
                                 from r in db.Races
                                 where c.Id == id
                                 where c.Id == r.ExtCircuit
                                 select new CircuitDto
                                 {
                                     Id = c.Id,
                                     Name = c.Name,
                                     Img = c.Img,
                                     CountryName = r.ExtCountry
                                 }).FirstOrDefaultAsync();

            if (circuit == null)
            {
                return NotFound();
            }

            return Ok(circuit);
        }

        // GET: api/Circuits/5/details
        [Route("{id:int}/details")]
        [ResponseType(typeof(CircuitDetailDto))]
        public async Task<IHttpActionResult> GetCircuitDetail(int id)
        {
            var circuit = await (from c in db.Circuits
                                 from r in db.Races
                                 where c.Id == r.ExtCircuit
                                 where c.Id == id
                                 select new CircuitDetailDto
                                 {
                                     Id = c.Id,
                                     Name = c.Name,
                                     City = c.City,
                                     Length = c.Length,
                                     RecordLap = c.RecordLap,
                                     Img = c.Img,
                                     FirstGrandPrix = c.FirstGrandPrix,
                                     CountryName = r.ExtCountry,
                                     RaceGrandPrixDate = r.GrandPrixDate,
                                     RaceGrandPrixName = r.GrandPrixName,
                                     RaceNLaps = r.NLaps,
                                 }).FirstOrDefaultAsync();

            if (circuit == null)
            {
                return NotFound();
            }

            return Ok(circuit);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CircuitExists(int id)
        {
            return db.Circuits.Count(e => e.Id == id) > 0;
        }
    }
}