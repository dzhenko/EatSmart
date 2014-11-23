using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using EatSmart.ViewModels.Basic;
using Parse;
using EatSmart.Models;
using System.Threading.Tasks;
using SQLite;

namespace EatSmart.Services
{
    public class AllFoodsFetcherService
    {
        public IEnumerable<FoodCategoryViewModel> GetAllCategories()
        {
            var categories = App.Database.Value.Table<FoodCategoryViewModel>().ToListAsync().Result;

            return categories;
        }

        public IEnumerable<FoodCategoryItemViewModel> GetFoodsInCategory(FoodCategoryViewModel category)
        {
            return this.GetFoodsInCategory(category.Name);
        }

        public IEnumerable<FoodCategoryItemViewModel> GetFoodsInCategory(string category)
        {
            var items = App.Database.Value.Table<FoodCategoryItemViewModel>()
                .Where(i => i.CategoryName == category).ToListAsync().Result;

            return items;
        }
    }
}
