using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EatSmart
{
    public static class Extensions
    {
        public static void Add<T>(this ObservableCollection<T> collection, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                collection.Add(item);
            }
        }
    }
}
