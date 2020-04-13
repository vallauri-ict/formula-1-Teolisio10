using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FormulaOneDll;

namespace FormulaOneWebApi.Controllers
{
    public class DriversAPIController : ApiController
    {
        DbTools db = new DbTools();

        public IEnumerable<Driver> GetAllDrivers()
        {
            return db.GetDrivers().Values;
        }

        public IHttpActionResult GetDriver(int id)
        {
            Dictionary<int, Driver> d = db.GetDrivers();
            var driver = d.FirstOrDefault((dr) => dr.Value.Id == id);
            if (driver.Value == null)
                return NotFound();
            return Ok(driver.Value);
        }
    }
}
