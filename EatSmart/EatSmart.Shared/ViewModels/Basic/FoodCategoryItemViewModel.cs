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
    public class FoodCategoryItemViewModel : ViewModelBase
    {
        public static Expression<Func<FoodCategoryItem, FoodCategoryItemViewModel>> FromData
        {
            get
            {
                return f => new FoodCategoryItemViewModel()
                {
                    Name = f.Name,
                    CategoryName = f.Category.FetchAsync().Result.Name,
                    Image = f.Image.Url.AbsoluteUri,
                    KCal = f.KCal,
                    Protein = f.Protein,
                    Carbohydrates = f.Carbohydrates,
                    Fats = f.Fats
                };
            }
        }

        [AutoIncrement]
        [PrimaryKey]
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public string Description
        {
            get
            {
                return string.Format("KCals: {0}, Proteins: {1}, Carbohydrates: {2}, Fats: {3}",
                                    this.KCal, this.Protein, this.Carbohydrates, this.Fats);
            }
        }

        public string Name { get; set; }

        public string Image { get; set; }

        public double KCal { get; set; }

        public double Protein { get; set; }

        public double Carbohydrates { get; set; }

        public double Fats { get; set; }
    }
}
