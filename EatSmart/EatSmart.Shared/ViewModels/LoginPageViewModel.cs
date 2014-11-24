using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;
using Parse;
using System.Threading.Tasks;
using EatSmart.ViewModels.Basic;
using EatSmart.Services;

namespace EatSmart.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        public LoginPageViewModel()
        {
            this.User = new UserViewModel();
        }

        public UserViewModel User { get; set; }

        public async Task<bool> Login()
        {
            try
            {
                await ParseUser.LogInAsync(this.User.Username, this.User.Password);
                await new UserSessionPersister().LoginUser(this.User.Username);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
