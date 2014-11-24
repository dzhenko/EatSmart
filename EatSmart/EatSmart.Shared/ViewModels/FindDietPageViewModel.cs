using EatSmart.Services;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace EatSmart.ViewModels
{
    public class FindDietPageViewModel : ViewModelBase
    {
        private string diet;

        public FindDietPageViewModel()
        {
            this.diet = new SuitableStuffFetcherService().GetDiet();
        }

        public string Diet
        {
            get
            {
                return this.diet;
            }
            set
            {
                this.diet = value;
                this.RaisePropertyChanged(() => this.Diet);
            }
        }
    }
}
