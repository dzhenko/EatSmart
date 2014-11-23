using System;
using System.Collections.Generic;
using System.Text;
using Parse;

namespace EatSmart.Models
{
    [ParseClassName("SuitableFoodCategoryItem")]
    public class SuitableFoodCategoryItem : ParseObject
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
        public SuitableFoodCategory Category
        {
            get { return GetProperty<SuitableFoodCategory>(); }
            set { SetProperty<SuitableFoodCategory>(value); }
        }

        [ParseFieldName("Amount")]
        public string Amount
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("Order")]
        public int Order
        {
            get { return GetProperty<int>(); }
            set { SetProperty<int>(value); }
        }
    }
}
