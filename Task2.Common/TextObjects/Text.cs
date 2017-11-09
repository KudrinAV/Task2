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

        public IEnumerable<string> FindWordsInInterrogativeSentences(int length)
        {
            var finding = from sentence in Sentences
                          group sentence by sentence.IsInterrogativeSentence() into interrogativeSentences
                          where interrogativeSentences.Key
                          from elements in interrogativeSentences
                          from element in elements.Elements
                          group element by element is IWord && element.Value.Length == length into wordGroup
                          where wordGroup.Key
                          from word in wordGroup
                          group word by word.Value.ToLower() into result
                          select result.Key;
                
            return finding;
        }

        public IEnumerable<ISentence> ShowAllSentncesSortedByNumberOfWordsAsc()
        {
            var sort = Sentences.OrderBy(x => x.GetNumberOfWords());
            return sort;
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
