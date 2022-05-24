using Microsoft.EntityFrameworkCore;
using Strona_internetowa.Data;
using Strona_internetowa.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Strona_internetowa.Services
{
    public class SurveyServices : SurveyContract
    {
        private readonly newSurveyContext _surveyContext;

        public List<Survey> GetSurveys()
        {
            throw new NotImplementedException();
            /*var context = new SurveyContext(optionsBuilder.Options);
            List<Survey> allsurveys = context.survey.Include(c => c.allergylist).ToList();
            return allsurveys; */
        }

        public Survey GetSurvey(int id)
        {
            throw new NotImplementedException();
            /*var context = new SurveyContext();
            Survey sur = context.survey.Where(c => c.allergylist == List<id>).FirstOrDefault();
            return sur;*/
        }
    }
}
