using EatSmart.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Parse;
using EatSmart.Models;
using EatSmart.ViewModels.Basic;

namespace EatSmart.Services
{
    public class SuitableFoodsFetcherService
    {
        public IEnumerable<SuitableFoodCategoryViewModel> GetAllCategories()
        {
            var categories = App.Database.Value.Table<SuitableFoodCategoryViewModel>().ToListAsync().Result;

            return categories;
        }

        public IEnumerable<SuitableFoodCategoryItemViewModel> GetFoodsInCategory
            (SuitableFoodCategoryViewModel category)
        {
            return this.GetFoodsInCategory(category.Name);
        }

        public IEnumerable<SuitableFoodCategoryItemViewModel> GetFoodsInCategory(string category)
        {
            var items = App.Database.Value.Table<SuitableFoodCategoryItemViewModel>()
                .Where(i => i.CategoryName == category).ToListAsync().Result;

            return items;
        }
    }
}
