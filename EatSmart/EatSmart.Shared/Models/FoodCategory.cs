using System;
using System.Collections.Generic;
using System.Text;
using Parse;

namespace EatSmart.Models
{
    [ParseClassName("FoodCategory")]
    public class FoodCategory : ParseObject
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

        [ParseFieldName("Items")]
        public IEnumerable<FoodCategoryItem> Items
        {
            get { return GetProperty<IEnumerable<FoodCategoryItem>>(); }
            set { SetProperty<IEnumerable<FoodCategoryItem>>(value); }
        }
    }
}
