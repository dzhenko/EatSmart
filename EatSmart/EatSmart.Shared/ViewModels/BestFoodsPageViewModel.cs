namespace EatSmart.ViewModels
{
    using System;
    using System.Collections.Generic;

    using GalaSoft.MvvmLight;

    using EatSmart.Logic;
    using System.Collections.ObjectModel;

    public class BestFoodsPageViewModel : ViewModelBase
    {
        private Lazy<Dictionary<string, Func<IEnumerable<string>>>> bestFoodOptions
            = new Lazy<Dictionary<string, Func<IEnumerable<string>>>>(PopulateDict);

        private ObservableCollection<string> foods;
        private string selectedOption;

        public BestFoodsPageViewModel()
        {
            this.foods = new ObservableCollection<string>();
        }

        public IEnumerable<string> AllOptions
        {
            get
            {
                return this.bestFoodOptions.Value.Keys;
            }
        }

        public string SelectedOption
        {
            get
            {
                return this.selectedOption;
            }
            set
            {
                if (this.bestFoodOptions.Value.ContainsKey(value))
                {
                    this.Foods = bestFoodOptions.Value[value]();
                }
            }
        }

        public IEnumerable<string> Foods
        {
            get
            {
                return this.foods;
            }
            set 
            {
                this.foods.Clear();
                foreach (var item in value)
                {
                    this.foods.Add(item);
                }

                this.RaisePropertyChanged(() => this.Foods);
            }
        }

        private static Dictionary<string, Func<IEnumerable<string>>> PopulateDict()
        {
            var fetcher = new SuitableFoodsFetcher();
            var dict = new Dictionary<string, Func<IEnumerable<string>>>();

            dict.Add("HighCalories", fetcher.HighCalories);
            dict.Add("HighCarbohydrates", fetcher.HighCarbohydrates);
            dict.Add("HighFat", fetcher.HighFat);

            dict.Add("LowCalories", fetcher.LowCalories);
            dict.Add("LowCarbohydrates", fetcher.LowCarbohydrates);
            dict.Add("LowFat", fetcher.LowFat);

            dict.Add("WeightGain", fetcher.WeightGain);
            dict.Add("OptimumHealth", fetcher.OptimumHealth);
            dict.Add("WeightLoss", fetcher.WeightLoss);

            return dict;
        }
    }
}
