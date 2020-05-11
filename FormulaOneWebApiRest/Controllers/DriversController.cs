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
    public class DriversController : ApiController
    {
        private FormulaOneWebApiRestContext db = new FormulaOneWebApiRestContext();

        // GET: api/Drivers
        public IQueryable<Driver> GetDrivers()
        {
            return db.Drivers;
        }

        // GET: api/Drivers/5
        [ResponseType(typeof(Driver))]
        public async Task<IHttpActionResult> GetDrivers(int id)
        {
            Driver drivers = await db.Drivers.FindAsync(id);
            if (drivers == null)
            {
                return NotFound();
            }

            return Ok(drivers);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DriversExists(int id)
        {
            return db.Drivers.Count(e => e.Id == id) > 0;
        }
    }
}