using EatSmart.ViewModels.Basic;
using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml.Data;

namespace EatSmart.Converters
{
    public class AllFoodItemToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var obj = value as FoodCategoryItemViewModel;
            if (obj == null)
            {
                return null;
            }

            return string.Format("{4} : KCals: {0}, Proteins: {1}, Carbohydrates: {2}, Fats: {3}",
                                    obj.KCal, obj.Protein, obj.Carbohydrates, obj.Fats, obj.Name);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return null;
        }
    }
}
