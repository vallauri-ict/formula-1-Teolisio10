using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FormulaOneDll;

namespace FormulaOneWebApi.Controllers
{
    public class CountriesAPIController : ApiController
    {
        DbTools db = new DbTools();

        public IEnumerable<Country> GetAllCountries()
        {
            return db.GetCountries().Values;
        }

        public IHttpActionResult GetCountry(string id)
        {
            Dictionary<string, Country> d = db.GetCountries();
            var country = d.FirstOrDefault((c) => c.Value.CountryCode == id);
            if (country.Value == null)
                return NotFound();
            return Ok(country.Value);
        }
    }
}
