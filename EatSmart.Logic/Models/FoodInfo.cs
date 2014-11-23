namespace EatSmart.Logic.Models
{
    public class FoodInfo
    {
        public FoodInfo(double calories, string amount, string name)
        {
            this.Calories = calories;
            this.Amount = amount;
            this.Name = name;
        }

        public double Calories { get; set; }

        public string Amount { get; set; }

        public string Name { get; set; }
    }
}
