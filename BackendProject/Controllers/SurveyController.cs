using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Strona_internetowa.Data;
using Strona_internetowa.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Strona_internetowa.Pages
{
    [Route("api/SurveyController")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        private readonly newSurveyContext _surveyContext;
        public SurveyController(newSurveyContext context)
        {
            _surveyContext = context;
        }
        // GET: api/<ValuesController>
        [HttpGet("Get")]
        public List<Survey> GetSurveys()
        {
            List<Survey> allsurveys = _surveyContext.survey
                                        .Include(a => a.person)
                                        .Include(a => a.allergylist)
                                        .Include(a => a.healthProblemlist)
                                        .Include(a => a.sicknesslist)
                                        .Include(a => a.foodAvoidedlist)
                                        .ToList();
            return allsurveys;
        }

        // GET api/<ValuesController>/5
        [HttpGet("Get/{id}")]
        public List<Survey> Get(int id)
        {
            List<Survey> sur = _surveyContext.survey
                                        .Where(a => a.surveyID == id)
                                        .Include(a => a.person)
                                        .Include(a => a.allergylist)
                                        .Include(a => a.healthProblemlist)
                                        .Include(a => a.sicknesslist)
                                        .Include(a => a.foodAvoidedlist)
                                        .ToList();

            return sur;
        }

        // POST api/<ValuesController>
        [HttpPost("Post")]
        public void Post([FromBody] Survey value)
        {
            _surveyContext.Add(value);
            _surveyContext.SaveChanges();
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("Delete/{id}")]
        public void Delete(int id)
        {

            List<Survey> drop = _surveyContext.survey
                                        .Where(a => a.surveyID == id)
                                        .Include(a => a.person)
                                        .Include(a => a.allergylist)
                                        .Include(a => a.healthProblemlist)
                                        .Include(a => a.sicknesslist)
                                        .Include(a => a.foodAvoidedlist)
                                        .ToList();

            _surveyContext.survey.RemoveRange(_surveyContext.survey.Where(a => a.surveyID == id));
            _surveyContext.SaveChanges();

        }
    }
}
