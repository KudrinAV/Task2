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
        public List<ISentenceElement> Elements { get; private set; }

        public int GetNumberOfWords()
        {
            //int coun = 0;
            //Func<List<ISentenceElement>, int> count =
            //    item => Elements.Where(x => x is IWord).Count();
            var count = Elements.Where(x => x is IWord).Count();
            return count;
        }


        public void ReplaceWordForSubstring(int length)
        {
            throw new NotImplementedException();
        }

        public bool IsInterrogativeSentence()
        {
            return Elements.Last().ToString() == "?";
        }

        public Sentence()
        {
            Elements = new List<ISentenceElement>();
        }
    }
}
