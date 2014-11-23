using System;
using System.Collections.Generic;
using System.Text;
using Parse;

namespace EatSmart.Models
{
    [ParseClassName("FoodCategoryItem")]
    public class FoodCategoryItem : ParseObject
    {
        [ParseFieldName("Name")]
        public string Name
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("Image")]
        public ParseFile Image
        {
            get { return GetProperty<ParseFile>(); }
            set { SetProperty<ParseFile>(value); }
        }

        [ParseFieldName("Category")]
        public FoodCategory Category
        {
            get { return GetProperty<FoodCategory>(); }
            set { SetProperty<FoodCategory>(value); }
        }

        [ParseFieldName("KCal")]
        public double KCal
        {
            get { return GetProperty<double>(); }
            set { SetProperty<double>(value); }
        }

        [ParseFieldName("Protein")]
        public double Protein
        {
            get { return GetProperty<double>(); }
            set { SetProperty<double>(value); }
        }

        [ParseFieldName("Carbohydrates")]
        public double Carbohydrates
        {
            get { return GetProperty<double>(); }
            set { SetProperty<double>(value); }
        }

        [ParseFieldName("Fats")]
        public double Fats
        {
            get { return GetProperty<double>(); }
            set { SetProperty<double>(value); }
        }
    }
}
