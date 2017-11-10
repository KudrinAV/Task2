using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Contracts.Interfaces;

namespace Task2.Contracts.ParserInterfaces
{
    public interface IParser
    {
        IText ParseText(StreamReader streamReader);
        ISentence ParseSentence(string sentence);

    }
}
