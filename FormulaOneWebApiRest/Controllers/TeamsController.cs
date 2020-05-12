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
    [RoutePrefix("api/Teams")]
    public class TeamsController : ApiController
    {
        private FormulaOneWebApiRestContext db = new FormulaOneWebApiRestContext();

        // GET: api/Teams
        [Route("")]
        public IQueryable<TeamDto> GetTeams()
        {
            return (from t in db.Teams
                    select new TeamDto
                    {
                        Id = t.Id,
                        Logo = t.Logo,
                        Name = t.Name,
                        FirstDriverFirstname = t.Driver1.Firstname,
                        FirstDriverLastname = t.Driver1.Lastname,
                        SecondDriverFirstname = t.Driver2.Firstname,
                        SecondDriverLastname = t.Driver2.Lastname
                    }
               );
        }

        // GET: api/Teams/5
        [Route("{id:int}")]
        [ResponseType(typeof(TeamDto))]
        public async Task<IHttpActionResult> GetTeam(int id)
        {
            var team = await (from t in db.Teams
                              select new TeamDto
                              {
                                  Id = t.Id,
                                  Logo = t.Logo,
                                  Name = t.Name,
                                  FirstDriverFirstname = t.Driver1.Firstname,
                                  FirstDriverLastname = t.Driver1.Lastname,
                                  SecondDriverFirstname = t.Driver2.Firstname,
                                  SecondDriverLastname = t.Driver2.Lastname
                              }).FirstOrDefaultAsync();
            if (team == null)
            {
                return NotFound();
            }

            return Ok(team);
        }

        // GET: api/Teams/5/details
        [Route("{id:int}/details")]
        [ResponseType(typeof(TeamDetailDto))]
        public async Task<IHttpActionResult> GetTeamDetail(int id)
        {
            var team = await (from t in db.Teams
                              where t.Id == id
                              select new TeamDetailDto
                              {
                                  Id = t.Id,
                                  Logo = t.Logo,
                                  Name = t.Name,
                                  FullTeamName = t.FullTeamName,
                                  PowerUnit = t.PowerUnit,
                                  TechnicalChief = t.TechnicalChief,
                                  Chassis = t.Chassis,
                                  FirstDriverFirstname = t.Driver1.Firstname,
                                  FirstDriverLastname = t.Driver1.Lastname,
                                  FirstDriverNumber = t.Driver1.Number,
                                  FirstDriverImage = t.Driver1.Image,
                                  SecondDriverFirstname = t.Driver2.Firstname,
                                  SecondDriverLastname = t.Driver2.Lastname,
                                  SecondDriverNumber = t.Driver2.Number,
                                  SecondDriverImage = t.Driver2.Image
                              }).FirstOrDefaultAsync();

            if (team == null)
            {
                return NotFound();
            }
            return Ok(team);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TeamExists(int id)
        {
            return db.Teams.Count(e => e.Id == id) > 0;
        }
    }
}