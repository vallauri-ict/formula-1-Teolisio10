using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FormulaOneDll;

namespace FormulaOneWebApi.Controllers
{
    public class CircuitsAPIController : ApiController
    {
        DbTools db = new DbTools();

        public IEnumerable<Circuit> GetAllCircuits()
        {
            return db.GetCircuits().Values;
        }

        public IHttpActionResult GetCircuits(int id)
        {
            Dictionary<int, Circuit> d = db.GetCircuits();
            var circuit = d.FirstOrDefault((c) => c.Value.Id == id);
            if (circuit.Value == null)
                return NotFound();
            return Ok(circuit.Value);
        }
    }
}
