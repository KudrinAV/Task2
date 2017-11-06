using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.CommonInterfaces.Interfaces;

namespace Task2.Common.TextObjects
{
    public class Sentence : ISentence
    {
        public int NumberOfWords => throw new NotImplementedException();

        public bool IsInterrogativeSentence => throw new NotImplementedException();

        List<ISentenceElement> ISentence.Sentence => throw new NotImplementedException();

        public void ReplaceWordForSubstring(int length)
        {
            throw new NotImplementedException();
        }
    }
}
