using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserObjectModel.TextModel.SentenceItems
{
    public class Word : SentenceItem, ICollection<Symbol>
    {

        public int Count 
        { 
            get
            {
                return chars.Count;
            }
        }

        private readonly List<char> vowels = new List<char>(){ 'a', 'e', 'i', 'o', 'u', 'y' };

        public bool IsReadOnly => chars.IsReadOnly;

        public void Add(Symbol item)
        {
            chars.Add(item);
        }

        public void Clear()
        {
            chars.Clear();
        }

        public void CopyTo(Symbol[] array, int arrayIndex)
        {
            chars.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Symbol> GetEnumerator()
        {
            return chars.GetEnumerator();
        }

        public bool Remove(Symbol item)
        {
            return chars.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)chars;
        }
    }
}
