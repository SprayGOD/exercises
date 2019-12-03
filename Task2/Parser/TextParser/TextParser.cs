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
    public class TextParser : IParser, IDisposable
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
            var word = new Word();
            var punctuationMark = new PunctuationMark();
            
            string line = String.Empty;
            string[] splitted;

            try
            {
                while ((line += streamReader.ReadLine()) != null)
                {

                    sentence = GetSentence(line);

                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return text;    
        }


        private Sentence GetSentence(string line)
        {
            Sentence sentence;
            SentenceItem sentenceItem; 
            string[] splitted = line.Split(new char[] { ' ' });

            foreach (var item in splitted)
            {
                sentenceItem = GetSentenceItem(item);
            }

            return sentence;
        }


        private SentenceItem GetSentenceItem(string subline)
        {
            
 

            return word;
        }


        private bool disposedValue = false; 

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (streamReader != null)
                        streamReader.Dispose();
                }


                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }


}
