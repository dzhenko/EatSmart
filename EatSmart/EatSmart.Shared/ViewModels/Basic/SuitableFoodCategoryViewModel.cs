using EatSmart.Models;
using GalaSoft.MvvmLight;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EatSmart.ViewModels.Basic
{
    public class SuitableFoodCategoryViewModel : ViewModelBase
    {
        public static Expression<Func<SuitableFoodCategory, SuitableFoodCategoryViewModel>> FromData
        {
            get
            {
                return s => new SuitableFoodCategoryViewModel()
                {
                    Name = s.Name
                };
            }
        }

        [AutoIncrement]
        [PrimaryKey]
        public int Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
