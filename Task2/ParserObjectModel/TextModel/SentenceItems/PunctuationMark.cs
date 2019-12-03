﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserObjectModel.TextModel.SentenceItems
{
    public class PunctuationMark : SentenceItem 
    {
        public static readonly IList<char> EndPunctuationSeparator = new List<char>() { '.',  '!', '?'};

        public static readonly IList<char> OtherPunctuationSeparator = new List<char>() { ',', ';', ':', '(', ')', '[', ']', '{', '}' };

        public PunctuationMark(char separator)
        {
            chars.Add(new Symbol(separator));
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
