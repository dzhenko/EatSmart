using EatSmart.Models;
using EatSmart.Services;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace EatSmart.ViewModels
{
    public class OwnProfilePageViewModel : ViewModelBase
    {
        private ProfileOverviewModel profileOverviewModel;

        public OwnProfilePageViewModel()
        {
            this.ProfileOverviewModel = new ProfileGeneratorService().GetProfile(new UserSessionPersister().GetCurrentUsername().Result).Result;
        }

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
