using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParserObjectModel.TextModel.SentenceItems;

namespace ParserObjectModel.TextModel
{
    public class Sentence : ICollection<SentenceItem>
    {
        public int Count 
        {
            get 
            {
                return SentenceItems.Count;
            }
        }

        public SentenceType SentenceType { get; set; }

        public IList<SentenceItem> SentenceItems { get; }

        public bool IsReadOnly => SentenceItems.IsReadOnly;

        public Sentence()
        {
            SentenceItems = new List<SentenceItem>();
        }

        public Sentence(IList<SentenceItem> sentenceItems)
        {
            this.SentenceItems = sentenceItems;
            
        }

        public IEnumerator<SentenceItem> GetEnumerator()
        {
            return SentenceItems.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)SentenceItems;
        }

        public void Add(SentenceItem item)
        {
            SentenceItems.Add(item);
        }

        public void Clear()
        {
            SentenceItems.Clear();
        }

        public bool Contains(SentenceItem item)
        {
            return SentenceItems.Contains(item);
        }

        public void CopyTo(SentenceItem[] array, int arrayIndex)
        {
            SentenceItems.CopyTo(array, arrayIndex);
        }

        public bool Remove(SentenceItem item)
        {
            return SentenceItems.Remove(item);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in SentenceItems)
            {
                sb.Append(item.ToString());
            }

            return sb.ToString();
        }
    }
}
