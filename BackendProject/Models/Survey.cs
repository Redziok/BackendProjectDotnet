using System;
using System.Collections.Generic;

namespace Strona_internetowa.Models
{
	public class Survey
	{
		public int surveyID { get; set; }
		public Person person { get; set; }
		public string work { get; set; }
		public string hoursWorked { get; set; }
		public string hoursRelaxed { get; set; }
		public string activityAmount { get; set; }
		public string favouriteActivity { get; set; }
		public string alcoholUsage { get; set; }
		public string cigaretteUsage { get; set; }
		public string coffeeUsage { get; set; }
		public string sleepQuality { get; set; }
		public string hoursSlept { get; set; }
		public string energyQuality { get; set; }
		public List<Sickness> sicknesslist { get; set; } = new List<Sickness>();
		public List<Allergy> allergylist { get; set; } = new List<Allergy>();
		public List<HealthProblem> healthProblemlist { get; set; } = new List<HealthProblem>();
		public bool medicationIntake { get; set; }
		public List<FoodAvoided> foodAvoidedlist { get; set; } = new List<FoodAvoided>();
	}
}