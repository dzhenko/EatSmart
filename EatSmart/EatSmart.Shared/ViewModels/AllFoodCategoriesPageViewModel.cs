using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using EatSmart.Models;
using Parse;
using GalaSoft.MvvmLight;
using EatSmart.ViewModels.Basic;
using EatSmart.Services;
using System.Collections.ObjectModel;

namespace EatSmart.ViewModels
{
    public class AllFoodCategoriesPageViewModel : ViewModelBase
    {
        private Lazy<ObservableCollection<FoodCategoryViewModel>> categories =
            new Lazy<ObservableCollection<FoodCategoryViewModel>>();

        public IEnumerable<FoodCategoryViewModel> Categories
        {
            get
            {
                return this.categories.Value;
            }
            set
            {
                this.categories.Value.Clear();
                this.categories.Value.Add(value);
                this.RaisePropertyChanged(() => this.Categories);
            }
        }

        public void Populate()
        {
            this.Categories = new AllFoodsFetcherService().GetAllCategories();
        }
    }
}
