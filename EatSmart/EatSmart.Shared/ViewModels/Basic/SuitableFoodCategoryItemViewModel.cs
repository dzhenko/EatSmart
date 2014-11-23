using EatSmart.Models;
using GalaSoft.MvvmLight;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Parse;

namespace EatSmart.ViewModels.Basic
{
    public class SuitableFoodCategoryItemViewModel : ViewModelBase
    {
        public static Expression<Func<SuitableFoodCategoryItem, SuitableFoodCategoryItemViewModel>> FromData
        {
            get
            {
                return s => new SuitableFoodCategoryItemViewModel()
                {
                    Name = s.Name,
                    CategoryName = s.Category.FetchAsync().Result.Name,
                    Image = s.Image.Url.AbsoluteUri,
                    Amount = s.Amount,
                    Order = s.Order
                };
            }
        }

        [AutoIncrement]
        [PrimaryKey]
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public string Amount { get; set; }

        public int Order { get; set; }
    }
}
