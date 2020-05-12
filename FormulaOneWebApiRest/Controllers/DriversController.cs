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

namespace FormulaOneWebApiRest.Controllers
{
    [RoutePrefix("api/drivers")]
    public class DriversController : ApiController
    {
        private FormulaOneWebApiRestContext db = new FormulaOneWebApiRestContext();

        // GET: api/Drivers
        [Route("")]
        public IQueryable<DriverDto> GetDrivers()
        {
            return (from t in db.Teams
                    from d in db.Drivers
                    where t.ExtFirstDriver == d.Id
                    select new DriverDto
                    {
                        Id = d.Id,
                        Number = d.Number,
                        Firstname = d.Firstname,
                        Lastname = d.Lastname,
                        Image = d.Image,
                        CountryFlag = d.Country.Flag,
                        TeamName = t.Name
                    }
               );
        }

        // GET: api/Drivers/5
        [Route("{id:int}")]
        [ResponseType(typeof(DriverDto))]
        public async Task<IHttpActionResult> GetDriver(int id)
        {
            var driver = await (from t in db.Teams
                                from d in db.Drivers
                                where t.ExtFirstDriver == d.Id
                                where d.Id == id
                                select new DriverDto
                                {
                                    Id = d.Id,
                                    Number = d.Number,
                                    Firstname = d.Firstname,
                                    Lastname = d.Lastname,
                                    Image = d.Image,
                                    CountryFlag = d.Country.Flag,
                                    TeamName = t.Name
                                }).FirstOrDefaultAsync();
            if (driver == null)
            {
                return NotFound();
            }

            return Ok(driver);
        }

        // GET: api/Drivers/5/details
        [Route("{id:int}/details")]
        [ResponseType(typeof(DriverDetailDto))]
        public async Task<IHttpActionResult> GetDriverDetail(int id)
        {
            var driver = await (from d in db.Drivers
                                from t in db.Teams
                                where t.ExtFirstDriver == d.Id
                                where d.Id == id
                                select new DriverDetailDto
                                {
                                    Id = d.Id,
                                    Number = d.Number,
                                    Firstname = d.Firstname,
                                    Lastname = d.Lastname,
                                    Dob = d.Dob,
                                    PlaceOfBirth = d.PlaceOfBirth,
                                    Image = d.Image,
                                    CountryFlag = d.Country.Flag,
                                    CountryName = d.Country.CountryName,
                                    TeamName = t.Name
                                }).FirstOrDefaultAsync();

            if (driver == null)
            {
                return NotFound();
            }
            return Ok(driver);
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