using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Contracts.Interfaces
{
    public interface ISentence
    {
        List<ISentenceElement> Elements { get; }
        int IndexOfLine {get;}

        int GetNumberOfWords();
        bool IsInterrogativeSentence();
        void ReplaceWordForSubstring(int length, string subString);
        void DeleteWordOnConsonant(int length);
        void SetIndexOfLine(int indexOfLine);
    }
}
