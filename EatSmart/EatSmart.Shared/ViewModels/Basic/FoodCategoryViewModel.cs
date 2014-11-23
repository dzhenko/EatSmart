using EatSmart.Models;
using GalaSoft.MvvmLight;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EatSmart.ViewModels.Basic
{
    public class FoodCategoryViewModel : ViewModelBase
    {
        public static Expression<Func<FoodCategory, FoodCategoryViewModel>> FromData
        {
            get
            {
                return f => new FoodCategoryViewModel()
                {
                    Name = f.Name,
                    Image = f.Image.Url.AbsoluteUri
                };
            }
        }

        [AutoIncrement]
        [PrimaryKey]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }
    }
}
