using EatSmart.Services;
using EatSmart.ViewModels.Basic;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EatSmart.ViewModels
{
    public class RichInContentFoodsPageViewModel : ViewModelBase
    {
        private Lazy<ObservableCollection<SuitableFoodCategoryViewModel>> categories =
            new Lazy<ObservableCollection<SuitableFoodCategoryViewModel>>();

        private Dictionary<string, IEnumerable<SuitableFoodCategoryItemViewModel>> dict =
            new Dictionary<string, IEnumerable<SuitableFoodCategoryItemViewModel>>();

        private ObservableCollection<SuitableFoodCategoryItemViewModel> foods;
        private SuitableFoodCategoryViewModel selectedOption;

        public RichInContentFoodsPageViewModel()
        {
            this.foods = new ObservableCollection<SuitableFoodCategoryItemViewModel>();
            this.Categories = new SuitableFoodsFetcherService().GetAllCategories();
        }

        public IEnumerable<SuitableFoodCategoryViewModel> Categories
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

        public SuitableFoodCategoryViewModel SelectedOption
        {
            get
            {
                return this.selectedOption;
            }
            set
            {
                if (!this.dict.ContainsKey(value.Name))
                {
                    this.dict.Add(value.Name, new SuitableFoodsFetcherService().GetFoodsInCategory(value));
                }

                this.Foods = this.dict[value.Name];
            }
        }

        public IEnumerable<SuitableFoodCategoryItemViewModel> Foods
        {
            get
            {
                return this.foods;
            }
            set
            {
                this.foods.Clear();
                this.foods.Add(value);
                this.RaisePropertyChanged(() => this.Foods);
            }
        }
    }
}
