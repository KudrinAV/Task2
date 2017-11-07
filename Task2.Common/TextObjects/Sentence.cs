using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.CommonInterfaces.Interfaces;

namespace Task2.CommonClasses.TextObjects
{
    public class Sentence : ISentence
    {
        public int NumberOfWords => throw new NotImplementedException();

        public bool IsInterrogativeSentence => throw new NotImplementedException();

        public List<ISentenceElement> Elements { get; set; }

        public void ReplaceWordForSubstring(int length)
        {
            throw new NotImplementedException();
        }
        
        public Sentence()
        {
            Elements = new List<ISentenceElement>();
        }
    }
}
