using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentLibrary.SweetsDescription;

namespace PresentLibrary.Present
{
    public class Present : IPresent, ICollection<Sweets>
    {
        private IList<Sweets> CandyCollection { get; set; }

        public Present(string reciever)
        {
            CandyCollection = new List<Sweets>();
        }

        public int GetWeight()
        {
            int sum = (from candy in CandyCollection
                          select candy.Weight).Sum();

            return sum;
        }

        public IList<Sweets> SearchBySugar(double min, double max)
        {
            IList<Sweets> searchResult = (IList<Sweets>)from item in CandyCollection
                               where item.SugarPercentage >= min && item.SugarPercentage <= max
                               select item;

            return searchResult;
        }

        public IList<Sweets> SortBySugar()
        {
            var sortedCollection = from candy in CandyCollection
                        orderby candy.SugarPercentage descending
                        select candy;

            return (IList<Sweets>)sortedCollection;
        }

        public IList<Sweets> SortByWeight()
        {
            var sortedCollection = from candy in CandyCollection
                                   orderby candy.Weight descending
                                   select candy;

            return (IList<Sweets>)sortedCollection;
        }

        public void Add(Sweets item)
        {
            CandyCollection.Add(item);
        }

        public void Clear()
        {
            CandyCollection.Clear();
        }

        public bool Contains(Sweets item)
        {
            return CandyCollection.Contains(item);
        }

        public int Count
        {
            get { return CandyCollection.Count; }
        }

        public bool IsReadOnly
        {
            get { return CandyCollection.IsReadOnly; }
        }

        public bool Remove(Sweets item)
        {
            return CandyCollection.Remove(item);
        }

        public void CopyTo(Sweets[] array, int arrayIndex)
        {
            CandyCollection.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Sweets> GetEnumerator()
        {
            return CandyCollection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) CandyCollection;
        }
    }
}
