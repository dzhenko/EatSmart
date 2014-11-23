namespace EatSmart.Models
{
    public class NutrientModel
    {
        public NutrientModel()
        {

        }

        public NutrientModel(string name, double amount, string measurment)
        {
            this.Name = name;
            this.Amount = amount;
            this.Measurment = measurment;
        }

        public string Name { get; set; }

        public double Amount { get; set; }

        public string Measurment { get; set; }
    }
}
