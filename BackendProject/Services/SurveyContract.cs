using Strona_internetowa.Models;
using System.Collections.Generic;

namespace Strona_internetowa.Services
{
    public interface SurveyContract 
    {
        Survey GetSurvey(int id);
        List<Survey> GetSurveys();
    }
}
