using EatSmart.Models;
using GalaSoft.MvvmLight;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EatSmart.ViewModels.Basic
{
    public class UserViewModel : ViewModelBase
    {
        [AutoIncrement]
        [PrimaryKey]
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string CodedProfile { get; set; }

        public LockSwipeType LockSwipeType { get; set; }
    }
}
