namespace EatSmart.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Linq;
    using System.Net.Http;
    using System.Text;
    using System.Text.RegularExpressions;

    using EatSmart.Logic.Models;

    public class ProfileGenerator
    {
        public async Task<ProfileOverviewModel> GetProfile(bool isMale, int age, int weight, int height, int lifestyleIndex = 0)
        {
            using (var httpClient = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Post, "http://nutritiondata.self.com/tools/calories-burned");
                request.Headers.Host = "nutritiondata.self.com";

                var contentAsString = string.Format("sex={0}&femaleStatus=none&age={1}&weight={2}&weightUnit=kg&height={3}.0&lifestyleIndex={4}&primaryExerciseMinutesPerDay=&primaryExercise=&primaryExerciseSelectedIndex=&primaryExerciseRelativeScore=0&secondaryExerciseMinutesPerDay=&secondaryExercise=&secondaryExerciseSelectedIndex=&secondaryExerciseRelativeScore=0&tertiaryExerciseMinutesPerDay=&tertiaryExercise=&tertiaryExerciseSelectedIndex=&tertiaryExerciseRelativeScore=0",
                    isMale ? "M" : "F", age, weight, height, lifestyleIndex);

                request.Content = new StringContent(contentAsString, UTF8Encoding.UTF8, "application/x-www-form-urlencoded");

                var response = await httpClient.SendAsync(request);
                var stringResponse = await response.Content.ReadAsStringAsync();
                var data = Regex.Split(stringResponse, @"<div class=""tbody2""");

                var profile = new ProfileOverviewModel();

                profile.Description = GetDescription(data[1]);

                if (string.IsNullOrEmpty(profile.Description))
                {
                    profile.Description = string.Format("You are a {0} year old {1}, {2}cm tall, with a current weight of {3}.0kg. You lead a very active lifestyle.", 
                        age, isMale ? "man" : "women", height, weight);
                }

                var bodyMassIndex = GetBodyMassIndex(data[2]);
                profile.BodyMassIndex = bodyMassIndex.Item1;
                profile.BodyMassIndexDescription = bodyMassIndex.Item2;

                var caloriesBurned = GetCaloriesBurned(data[3]);
                profile.CaloriesBurned = caloriesBurned.Item1;
                profile.CaloriesBurnedDescription = caloriesBurned.Item2;

                var minimums = GetYourRecommendedMinimums(data[4]);
                profile.RecomendedMinimumsGeneral = minimums.Item1;
                profile.RecomendedMinimumsVitamins = minimums.Item2;
                profile.RecomendedMinimumsMinerals = minimums.Item3;

                return profile;
            }
        }

        private string GetDescription(string data)
        {
            try
            {
                var startWord = "<strong>";
                var startIndex = data.IndexOf(startWord);
                var endIndex = data.IndexOf("</strong>");

                return data.Substring(startIndex + startWord.Length, endIndex - startIndex - startWord.Length);
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        private Tuple<int, string> GetCaloriesBurned(string data)
        {
            var number = 2745;
            try 
	        {	        
		        var numberString = data.Substring(data.IndexOf("<b>") + 3, 4);
                number = int.Parse(numberString);
	        }
	        catch (Exception)
	        {
	        }

            var description = "Accurate determination of the Calories you burn can only be accomplished by individual physiological testing. This calculation is merely an estimate that was derived from regression formulas";

            return new Tuple<int, string>(number, description);
        }

        private Tuple<double, string> GetBodyMassIndex(string data)
        {
            double number = 25.4;
            try
            {
                var numberIndex = data.IndexOf("<b>");
                var numberString = data.Substring(numberIndex + 3, 4);
                number = double.Parse(numberString);
            }
            catch (Exception)
            {
            }

            string description = "BMI is a standardized ratio of weight to height, and is often used as a general indicator of health. The \"normal\" BMI for an adult man of your height is 18.5 to 24.9. This translates to a healthy weight range of 53 to 72 kg.However, BMI does not take body composition into account. A weight above this range could still be considered healthy if your percentage body fat is less than average. For more accurate determination of body fat levels, consider using a body fat caliper.";
            try
            {
                var descriptionIndex = data.IndexOf("<p>");
                description = data.Substring(descriptionIndex + 3, data.IndexOf("</p>") - descriptionIndex - 3);
                description = description.Replace("&quot;", "");
            }
            catch (Exception)
            {
            }

            return new Tuple<double, string>(number, description);
        }

        private Tuple<IEnumerable<NutrientModel>, IEnumerable<NutrientModel>, IEnumerable<NutrientModel>> GetYourRecommendedMinimums(string data)
        {
            string[] measurments = new[] { "g", "g", "mg", "mg", "g", "IU", "mg", "IU", "mg", "mcg", "mg", "mg", "mg", "mg", "mcg", "mcg", "mg", "mg", "mg", "mg", "mg", "mg", "mg", "mcg", "mg" };
            var measurmentIndex = 0;

            var items = Regex.Split(data, @"00000000");
            List<NutrientModel> allMinimums = new List<NutrientModel>();
            List<NutrientModel> vitamins = new List<NutrientModel>();
            List<NutrientModel> minerals = new List<NutrientModel>();

            var dividerStart = @";"">";
            var dividerEnd = @"value=""";

            for (int i = 1; i < 6; i++)
            {
                try
                {
                    var indexStart = items[i].IndexOf(dividerStart);
                    var name = items[i].Substring(indexStart + dividerStart.Length, items[i].IndexOf("</a", indexStart + 1) - indexStart - dividerStart.Length);

                    var indexEnd = items[i].IndexOf(dividerEnd);
                    var valueString = items[i].Substring(indexEnd + dividerEnd.Length, items[i].IndexOf("\"", indexEnd + dividerEnd.Length + 1) - indexEnd - dividerEnd.Length);
                    var value = double.Parse(valueString);

                    allMinimums.Add(new NutrientModel(name, value, measurments[measurmentIndex++]));
                }
                catch (Exception)
                {
                }
            }

            for (int i = 6; i < 19; i++)
            {
                if (i == 13)
                {
                    continue;
                }

                try
                {
                    var indexStart = items[i].IndexOf(dividerStart);
                    var name = items[i].Substring(indexStart + dividerStart.Length, items[i].IndexOf("</a", indexStart + 1) - indexStart - dividerStart.Length);

                    var indexEnd = items[i].IndexOf(dividerEnd);
                    var valueString = items[i].Substring(indexEnd + dividerEnd.Length, items[i].IndexOf("\"", indexEnd + dividerEnd.Length + 1) - indexEnd - dividerEnd.Length);
                    var value = double.Parse(valueString);

                    vitamins.Add(new NutrientModel(name, value, measurments[measurmentIndex++]));
                }
                catch (Exception)
                {
                }
            }

            for (int i = 19; i < 27; i++)
            {
                if (i == 22)
                {
                    continue;
                }

                try
                {
                    var indexStart = items[i].IndexOf(dividerStart);
                    var name = items[i].Substring(indexStart + dividerStart.Length, items[i].IndexOf("</a", indexStart + 1) - indexStart - dividerStart.Length);

                    var indexEnd = items[i].IndexOf(dividerEnd);
                    var valueString = items[i].Substring(indexEnd + dividerEnd.Length, items[i].IndexOf("\"", indexEnd + dividerEnd.Length + 1) - indexEnd - dividerEnd.Length);
                    var value = double.Parse(valueString);

                    minerals.Add(new NutrientModel(name, value, measurments[measurmentIndex++]));
                }
                catch (Exception)
                {
                }
            }

            return new Tuple<IEnumerable<NutrientModel>, IEnumerable<NutrientModel>, IEnumerable<NutrientModel>>(allMinimums, vitamins, minerals);
        }
    }
}
