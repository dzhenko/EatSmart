using System;
using System.Collections.Generic;
using System.Text;
using Parse;

namespace EatSmart.Models
{
    [ParseClassName("SuitableFoodCategory")]
    public class SuitableFoodCategory : ParseObject
    {
        [ParseFieldName("Name")]
        public string Name
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("Items")]
        public IEnumerable<SuitableFoodCategoryItem> Items
        {
            get { return GetProperty<IEnumerable<SuitableFoodCategoryItem>>(); }
            set { SetProperty<IEnumerable<SuitableFoodCategoryItem>>(value); }
        }
    }
}
