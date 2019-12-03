using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParserObjectModel.TextModel.SentenceItems;


namespace ParserObjectModel.TextModel
{
    public class Text : ICollection<Sentence>
    {
        public IList<Sentence> Sentences { get; } 
        public int Count 
        { 
            get
            { 
                return Sentences.Count; 
            }
        }

        public bool IsReadOnly => Sentences.IsReadOnly;

        public Text()
        {
            Sentences = new List<Sentence>();
        }

        public Text(IList<Sentence> sentences)
        {
            this.Sentences = sentences;
        }

        public void Add(Sentence item)
        {
            Sentences.Add(item);
        }

        public void Clear()
        {
            Sentences.Clear();
        }

        public bool Contains(Sentence item)
        {
            return Sentences.Contains(item);
        }

        public void CopyTo(Sentence[] array, int arrayIndex)
        {
            Sentences.CopyTo(array, arrayIndex);
        }

        public bool Remove(Sentence item)
        {
            return Sentences.Remove(item);
        }

        public IEnumerator<Sentence> GetEnumerator()
        {
            return Sentences.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)Sentences;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Sentences)
            {
                sb.Append(item);
            }

            return sb.ToString();
        }

        public IEnumerable GetSentencesByWordsCount()
        {
            return Sentences.OrderBy(s => s.SentenceItems.OfType<Word>().Count());
        }

        public IEnumerable GetWordsByLengthInInterrogativeSentences(int length)
        {
            HashSet<SentenceItem> hash = new HashSet<SentenceItem>();

            foreach (var sentence in Sentences)
            {
                if (sentence.SentenceType == SentenceType.Interrogative)
                    hash = sentence.GetWordsByLength(length);
            }

            return hash;
        }
    }
}
