using EatSmart.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.RegularExpressions;
using EatSmart.ViewModels.Basic;

namespace EatSmart.Services
{
    public class UserSessionPersister
    {
        public async Task<string> GetCurrentUsername()
        {
            var result = App.Database.Value.Table<UserSessionHolderViewModel>().FirstOrDefaultAsync().Result.Username;
            return result;
        }

        public async Task<bool> IsUserLoggedIn()
        {
            var result = App.Database.Value.Table<UserSessionHolderViewModel>().FirstOrDefaultAsync().Result;
            if (result == null)
            {
                return false;
            }

            return result.LoggedIn;
        }

        public async Task<bool> LoginUser(string username)
        {
            var user = App.Database.Value.Table<UserSessionHolderViewModel>().FirstOrDefaultAsync().Result;
            if (user == null)
            {
                await App.Database.Value.InsertAsync(new UserSessionHolderViewModel() { Username = username, LoggedIn = true });
            }
            else
            {
                user.LoggedIn = true;
                await App.Database.Value.UpdateAsync(user);
            }            

            return true;
        }

        public async Task<bool> LogoutUser()
        {
            var user = App.Database.Value.Table<UserSessionHolderViewModel>().FirstOrDefaultAsync().Result;
            if (user.LoggedIn)
            {
                user.LoggedIn = false;
                App.Database.Value.UpdateAsync(user);
            }

            return true;
        }
    }
}
