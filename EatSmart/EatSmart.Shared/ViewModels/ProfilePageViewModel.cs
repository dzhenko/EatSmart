using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;
using EatSmart.Models;

namespace EatSmart.ViewModels
{
    public class ProfilePageViewModel : ViewModelBase
    {
        private ProfileOverviewModel profileOverviewModel;

        public ProfileOverviewModel ProfileOverviewModel
        {
            get
            {
                return this.profileOverviewModel;
            }
            set
            {
                this.profileOverviewModel = value;
                this.RaisePropertyChanged(() => this.ProfileOverviewModel);
            }
        }
    }
}
