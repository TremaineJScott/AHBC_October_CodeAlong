using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CollectionManager.Interators
{
    public static class CollectionInteractor
    {
        public static void DisplayItem(ICollectable item)
        {
            Console.WriteLine($"{item.Name} - {item.Description} - {item.Price}");
        }

        public static ICollectable GetItem(IEnumerable<ICollectable> collection, string inputName)
        {
            return collection.Where(collectionItem => collectionItem.Name == inputName).First();
            // Look in the collection and filter items with the name equal to inputName
        }

        public static void DisplayAllItems(IEnumerable<ICollectable> collection)
        {
            IEnumerable<ICollectable> sortedList = 
                collection.OrderBy(collectionItem => collectionItem.Name);
            // Look at all the Names of the items and order them 

            foreach (ICollectable item in sortedList)
            {
                Console.WriteLine($"{item.Name} - {item.Description} - {item.Price}");
            }
        }

        public static double GetTotalAmountSpent(IEnumerable<ICollectable> collection)
        {
            return collection.Select(x => x.Price).Sum();
            // collection.Select(x => x.Price) Select only the prices from the collection object
        }

        //public static void AddNewItem(ICollection collection, ICollectable item)
        //{
        //    collection.Add(item);
        //}

    }
}
