using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.CommonInterfaces.Interfaces;

namespace Task2.CommonInterfaces.ParserInterfaces
{
    interface IParser
    {
        IText TextParser(StreamReader streamReader);
        ISentence SentenceParser(string sentence);

    }
}
