using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Contracts.Structs;

namespace Task2.Contracts.Interfaces
{
    public interface IWord : ISentenceElement
    {
        int Lenght { get; }

        bool IsAVowel();
        Symbol ToSymbols();
    }
}
