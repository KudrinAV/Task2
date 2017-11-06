using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.CommonInterfaces.Structs;

namespace Task2.CommonInterfaces.Interfaces
{
    public interface IPunctuationMark : ISentenceElement
    {
        bool IsItFinishedMark { get; }
        Symbol Symbols { get; }

    }
}
