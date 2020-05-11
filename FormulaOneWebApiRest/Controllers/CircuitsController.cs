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
    public class CircuitsController : ApiController
    {
        private FormulaOneWebApiRestContext db = new FormulaOneWebApiRestContext();

        // GET: api/Circuits
        public IQueryable<Circuit> GetCircuits()
        {
            return db.Circuits;
        }

        // GET: api/Circuits/5
        [ResponseType(typeof(Circuit))]
        public async Task<IHttpActionResult> GetCircuit(int id)
        {
            Circuit circuit = await db.Circuits.FindAsync(id);
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