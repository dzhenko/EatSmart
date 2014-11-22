using GalaSoft.MvvmLight;
using Parse;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EatSmart.ViewModels
{
    public class RegisterPageViewModel : ViewModelBase
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public async Task<bool> Register()
        {
            try
            {
                var user = new ParseUser()
                {
                    Username = this.Username,
                    Password = this.Password
                };

                await user.SignUpAsync();

                // TODO: login

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
