using Microsoft.EntityFrameworkCore;
using Strona_internetowa.Models;

namespace Strona_internetowa.Data
{
    public class newSurveyContext : DbContext
    {
        public newSurveyContext (DbContextOptions<newSurveyContext> options) : base(options) { }
        public DbSet<Survey> survey { get; set; }
        public DbSet<Person> person { get; set; }
        public DbSet<Allergy> allergy { get; set; }
        public DbSet<FoodAvoided> foodAvoided { get; set; }
        public DbSet<HealthProblem> healthProblem { get; set; }
        public DbSet<Sickness> sickness { get; set; }
    }
}
