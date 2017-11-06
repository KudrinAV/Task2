using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.CommonInterfaces.Structs;

namespace Task2.CommonInterfaces.Interfaces
{
    public interface IWord : ISentenceElement
    {
        int Lenght { get; }
        bool IsConstant { get; }

        Symbol ToSymbols();
    }
}
