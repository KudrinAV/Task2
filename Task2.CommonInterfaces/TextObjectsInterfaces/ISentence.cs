using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.CommonInterfaces.Interfaces
{
    public interface ISentence
    {
        List<ISentenceElement> Elements { get; }

        int GetNumberOfWords();
        bool IsInterrogativeSentence();
        void ReplaceWordForSubstring(int length);
    }
}
