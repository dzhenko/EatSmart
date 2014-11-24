using EatSmart.Services;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace EatSmart.ViewModels
{
    public class FindFoodPageViewModel : ViewModelBase
    {
        private string food;
        private string image;

        public FindFoodPageViewModel()
        {
            var data = new SuitableStuffFetcherService().GetFood();
            this.Image = data.Item1;
            this.Food = data.Item2;
        }

        public string Image
        {
            get
            {
                return this.image;
            }
            set
            {
                this.image = value;
                this.RaisePropertyChanged(() => this.Image);
            }
        }

        public string Food
        {
            get
            {
                return this.food;
            }
            set
            {
                this.food = value;
                this.RaisePropertyChanged(() => this.Food);
            }
        }
    }
}
