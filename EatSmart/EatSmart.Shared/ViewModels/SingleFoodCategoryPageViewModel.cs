using EatSmart.Services;
using EatSmart.ViewModels.Basic;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;

namespace EatSmart.ViewModels
{
    public class SingleFoodCategoryPageViewModel : ViewModelBase
    {
        private Lazy<ObservableCollection<FoodCategoryItemViewModel>> foods = 
            new Lazy<ObservableCollection<FoodCategoryItemViewModel>>();

        public IEnumerable<FoodCategoryItemViewModel> Foods
        {
            get
            {
                return this.foods.Value;
            }
            set
            {
                this.foods.Value.Clear();
                this.foods.Value.Add(value);
                this.RaisePropertyChanged(() => this.Foods);
                this.RaisePropertyChanged(() => this.TitleText);
            }
        }

        public string TitleText
        {
            get
            {
                return this.foods.Value.FirstOrDefault().Name;
            }
        }

        public void Populate(string categoryName)
        {
            this.Foods = new AllFoodsFetcherService().GetFoodsInCategory(categoryName);
        }
    }
}
