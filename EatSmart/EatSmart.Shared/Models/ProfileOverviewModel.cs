namespace EatSmart.Models
{
    using System.Collections.Generic;

    public class ProfileOverviewModel
    {
        public string Description { get; set; }

        public double BodyMassIndex { get; set; }

        public string BodyMassIndexDescription { get; set; }

        public int CaloriesBurned { get; set; }

        public string CaloriesBurnedDescription { get; set; }

        public IEnumerable<NutrientModel> RecomendedMinimumsGeneral { get; set; }

        public IEnumerable<NutrientModel> RecomendedMinimumsVitamins { get; set; }

        public IEnumerable<NutrientModel> RecomendedMinimumsMinerals { get; set; }
    }
}
