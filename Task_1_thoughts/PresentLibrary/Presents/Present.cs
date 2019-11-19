using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentLibrary.Sweets;

namespace PresentLibrary.Presents
{
    public class Present : IPresent, ICollection<Sweet>
    {
        private IList<Sweet> candyCollection;

        public Present()
        {
            candyCollection = new List<Sweet>();
        }

        public int GetWeight()
        {
            int sum = (from candy in candyCollection
                          select candy.Weight).Sum();

            return sum;
        }

        public IEnumerable<Sweet> SearchBySugar(int min, int max)
        {
            var searchResult = from item in candyCollection
                               where item.SugarPercentage >= min && item.SugarPercentage <= max
                               select item;

            return searchResult;
        }

        public IEnumerable<Sweet> SortBySugar(bool isDescending)
        {
            if (isDescending)
                return candyCollection.OrderByDescending(sweet => sweet.SugarPercentage);
            else
                return candyCollection.OrderBy(sweet => sweet.SugarPercentage);
        }

        public IEnumerable<Sweet> SortByWeight(bool isDescending)
        {
            if (isDescending)
                return candyCollection.OrderByDescending(sweet => sweet.Weight);
            else
                return candyCollection.OrderBy(sweet => sweet.Weight);
        }

        public void Add(Sweet item)
        {
            candyCollection.Add(item);
        }

        public void Clear()
        {
            candyCollection.Clear();
        }

        public bool Contains(Sweet item)
        {
            return candyCollection.Contains(item);
        }

        public int Count
        {
            get { return candyCollection.Count; }
        }

        public bool IsReadOnly
        {
            get { return candyCollection.IsReadOnly; }
        }

        public bool Remove(Sweet item)
        {
            return candyCollection.Remove(item);
        }

        public void CopyTo(Sweet[] array, int arrayIndex)
        {
            candyCollection.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Sweet> GetEnumerator()
        {
            return candyCollection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) candyCollection;
        }
    }
}
