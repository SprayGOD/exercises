using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserObjectModel.TextModel.SentenceItems
{
    public class Symbol
    {
        private char symbol;

        public Symbol(char symbol)
        {
            this.symbol = symbol;
        }

        public override string ToString()
        {
            return symbol.ToString();
        }
    }
}
