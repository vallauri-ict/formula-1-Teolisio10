using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
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
    [RoutePrefix("api/Races_Scores")]
    public class Races_ScoresController : ApiController
    {
        private FormulaOneWebApiRestContext db = new FormulaOneWebApiRestContext();

        // group by races

        // GET: api/races-results
        [Route("~/api/races-results")]
        public IQueryable<RacesResultDto> GetRacesResults()
        {
            return (from rasc in db.Races_Scores
                    select new RacesResultDto
                    {
                        Id = rasc.Id,
                        FastestLap = rasc.FastestLap,
                        DriverFirstname = rasc.Driver.Firstname,
                        DriverLastname = rasc.Driver.Lastname,
                        RaceNLaps = rasc.Race.NLaps,
                        RaceGrandPrixDate = rasc.Race.GrandPrixDate,
                        CountryName = rasc.Race.Country.CountryName
                    }
                );
        }

        // GET: api/races-results/5
        [Route("~/api/races-results/{id:int}")]
        [ResponseType(typeof(RacesResultDto))]
        public async Task<IHttpActionResult> GetRaceResults(int id)
        {
            var races_scores = await (from rasc in db.Races_Scores
                                      where rasc.ExtRace == id
                                      select new RacesResultDto
                                      {
                                          Id = rasc.Id,
                                          FastestLap = rasc.FastestLap,
                                          DriverFirstname = rasc.Driver.Firstname,
                                          DriverLastname = rasc.Driver.Lastname,
                                          RaceNLaps = rasc.Race.NLaps,
                                          RaceGrandPrixDate = rasc.Race.GrandPrixDate,
                                          CountryName = rasc.Race.Country.CountryName
                                      }).FirstOrDefaultAsync();
            if (races_scores == null)
            {
                return NotFound();
            }

            return Ok(races_scores);
        }

        // GET: api/races-results/5/details
        [Route("~/api/races-results/{id:int}/details")]
        [ResponseType(typeof(RacesResultsDetailDto))]
        public async Task<IHttpActionResult> GetRaceResultsDetail(int id)
        {
            var rs = await (from rasc in db.Races_Scores
                            where rasc.ExtRace == id
                            select new RacesResultsDetailDto
                            {
                                Id = rasc.Id,
                                FastestLap = rasc.FastestLap,
                                RacesNLaps = rasc.Race.NLaps,
                                DriverFirstname = rasc.Driver.Firstname,
                                DriverLastname = rasc.Driver.Lastname,
                                DriverNumber = rasc.Driver.Number,
                                ScoreId = rasc.Score.Id,
                                ScorePoints = rasc.Score.Points
                                // oh no, gestione giro veloce +1 
                            }).FirstOrDefaultAsync();
            if (rs == null)
            {
                return NotFound();
            }
            return Ok(rs);
        }

        // GET: api/Races_Scores
        [Route("~/api/ranking")]
        public IQueryable<RankingDto> GetRankings()
        {
            return (from rasc in db.Races_Scores
                    from d in db.Drivers
                    from t in db.Teams
                    from r in db.Races
                    from c in db.Countries
                    where rasc.ExtDriver == d.Id && (t.ExtFirstDriver == rasc.Driver.Id || t.ExtSecondDriver == rasc.Driver.Id)
                    where rasc.ExtRace == r.Id && c.CountryCode == rasc.Race.ExtCountry
                    select new RankingDto
                    {
                        Id = rasc.Id,
                        DriverFirstname = rasc.Driver.Firstname,
                        DriverLastname = rasc.Driver.Lastname,
                        CountryCode = c.CountryCode,
                        TeamName = t.Name/*,
                        Points = calcoloDinamico*/
                    }
               );
        }

        // GET: api/Races_Scores/5
        [Route("~/api/ranking/{id:int}")]
        [ResponseType(typeof(RankingDto))]
        public async Task<IHttpActionResult> GetRanking(int id)
        {
            // serve una group by
            RankingDto ranking = await(from rasc in db.Races_Scores
                                       from d in db.Drivers
                                       from t in db.Teams
                                       from r in db.Races
                                       from c in db.Countries
                                       where rasc.Id == id
                                       where rasc.ExtDriver == d.Id && (t.ExtFirstDriver == rasc.Driver.Id || t.ExtSecondDriver == rasc.Driver.Id)
                                       where rasc.ExtRace == r.Id && c.CountryCode == rasc.Race.ExtCountry
                                       select new RankingDto
                                       {
                                           Id = rasc.Id,
                                           DriverFirstname = rasc.Driver.Firstname,
                                           DriverLastname = rasc.Driver.Lastname,
                                           CountryCode = c.CountryCode,
                                           TeamName = t.Name/*,
                        Points = calcoloFinamico*/
                                       }).FirstOrDefaultAsync();
            if (ranking == null)
            {
                return NotFound();
            }

            return Ok(ranking);
        }

        // GET: api/Races_Scores/5/details
        [Route("~/api/ranking/{id:int}/details")]
        [ResponseType(typeof(RacesResultsDetailDto))]
        public async Task<IHttpActionResult> GetRankingsDetail(int id)
        {
            var rs = await (from rasc in db.Races_Scores
                            where rasc.Id == id
                            select new RacesResultsDetailDto
                            {
                                Id = rasc.Id,
                                FastestLap = rasc.FastestLap,
                                RacesNLaps = rasc.Race.NLaps,
                                DriverFirstname = rasc.Driver.Firstname,
                                DriverLastname = rasc.Driver.Lastname,
                                DriverNumber = rasc.Driver.Number,
                                ScoreId = rasc.Score.Id,
                                ScorePoints = rasc.Score.Points
                                // oh no, gestione giro veloce +1 
                            }).FirstOrDefaultAsync();

            if (rs == null)
            {
                return NotFound();
            }
            return Ok(rs);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Races_ScoresExists(int id)
        {
            return db.Races_Scores.Count(e => e.Id == id) > 0;
        }
    }
}