using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserObjectModel.TextModel.SentenceItems
{
    public abstract class SentenceItem 
    {
        protected IList<Symbol> chars { get; } 

        public int Count 
        {
            get 
            { 
                return chars.Count; 
            }
        }

        public bool Contains(Symbol item)
        {
            return chars.Contains(item);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in chars)
            {
                sb.Append(item);
            }

            return sb.ToString();
        }
    }
}
