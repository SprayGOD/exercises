using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ParserObjectModel;
using ParserObjectModel.TextModel;
using ParserObjectModel.TextModel.SentenceItems;

namespace Parser
{
    public interface IParser
    {
        Text Parse();
    } 
}
