﻿using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace EatSmart.ViewModels
{
    public class UserViewModel : ViewModelBase
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}