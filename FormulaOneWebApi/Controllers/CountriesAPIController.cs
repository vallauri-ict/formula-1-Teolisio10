using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FormulaOneWebApi.Models;
using FormulaOneDll;

namespace FormulaOneWebApi.Controllers
{
    public class CountriesAPIController : ApiController
    {
        DbTools db = new DbTools();

        // BISOGNEREBBE CONVERTIRE Country IN CountriesAPI, IL CONTROLLER
        // DA PROBLEMI SE SI IMMETTE IL PATH PER AVERE L'ELENCO XML 
        //  PROBABILMENTE PERCHE' COUNTRY NON E' UN CONTROLLER
        // UN ALTRO PROBLEMA PUO' ESSERE IL FATTO CHE SIA Dictionary
        public IEnumerable<Country> GetAllProducts()
        {
            return db.GetCountries().Values;
        }

        public IHttpActionResult GetProduct(string cc)
        {
            // country.Value COMPRENDE I DATI NEL FORMATO DI Country
            Dictionary<string, Country> d = db.GetCountries();
            var country = d.FirstOrDefault((c) => c.Value.CountryCode == cc);
            if (country.Value == null)
            {
                return NotFound();
            }
            return Ok(country.Value);
        }
    }
}
