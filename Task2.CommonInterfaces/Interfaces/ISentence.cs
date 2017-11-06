using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.CommonInterfaces.Interfaces
{
    public interface ISentence
    {
        List<ISentenceElement> Sentence { get; }
        int NumberOfWords { get; }

        void ReplaceWordForSubstring(int length);
    }
}
