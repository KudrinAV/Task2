using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.CommonInterfaces.Interfaces;
using Task2.CommonInterfaces.ParserInterfaces;

namespace Task2.Common.Parser
{
    class Parser : IParser
    {
        public ISentence SentenceParser(string sentence)
        {
            throw new NotImplementedException();
        }

        public IText TextParser(StreamReader streamReader)
        {
            throw new NotImplementedException();
        }
    }
}
