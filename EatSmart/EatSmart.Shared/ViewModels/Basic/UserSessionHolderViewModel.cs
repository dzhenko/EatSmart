using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EatSmart.ViewModels.Basic
{
    public class UserSessionHolderViewModel
    {
        [AutoIncrement]
        [PrimaryKey]
        public int Id { get; set; }

        public string Username { get; set; }

        public bool LoggedIn { get; set; }
    }
}
