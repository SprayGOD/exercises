using System;
using System.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParserObjectModel.TextModel;
using ParserObjectModel.TextModel.SentenceItems;

namespace Parser.TextParser
{
    public class TextParser : IParser
    {
        private StreamReader streamReader;

        public TextParser(string path)
        {
            streamReader = new StreamReader(path);
        }

        public Text Parse()
        {
            var text = new Text();
            var sentence = new Sentence();
            
            string line = String.Empty;
            int index = 0;

            try
            {
                while((line += streamReader.ReadLine()) != null)
                {
                    foreach (var item in line)
                    {
                        if(!PunctuationMark.EndPunctuationSeparator.Contains(item))
                        {
                            continue;
                        }
                        else
                        {
                            sentence = GetSentence(line, ref index);
                            text.Add(sentence);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return text;    
        }


        private Sentence GetSentence(string line, ref int index)
        {
            Sentence sentence = new Sentence();
            string[] splitted = 
            
            
            return sentence;
        }


        private Word GetWord(string line, ref int index)
        {
            Word word = new Word();

            while(Char.IsWhiteSpace(line[index]) != true)
            {
                //word.Add(line[index]);
            }

            return word;
        }
    }


}
