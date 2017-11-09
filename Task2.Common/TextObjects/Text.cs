using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.CommonInterfaces.Interfaces;

namespace Task2.CommonClasses.TextObjects
{
    public class Text : IText
    {
        public List<ISentence> Sentences { get; private set; }

        public void DeleteWordOnConstatnt(int length)
        {
            throw new NotImplementedException();
        }

        public void FindWordsInInterrogativeSentences(int length)
        {
            throw new NotImplementedException();
        }

        public Text()
        {
            Sentences = new List<ISentence>();
        }

        public Text(List<ISentence> sentences)
        {
            Sentences = sentences;
        }
    }
}
