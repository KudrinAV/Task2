using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Contracts.Interfaces;
using Task2.Contracts.Structs;

namespace Task2.CommonClasses.TextObjects
{
    public class Text : IText
    {
        public List<ISentence> Sentences { get; private set; }
        
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

        public void GetTheSentenceToReplaceWordOnSubString(int index, int length, string subString)
        {
            Sentences.ElementAt(index).ReplaceWordForSubstring(length, subString);
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

        public IEnumerable<IDictionary<string, Pair>> FindAllWord()
        {
            var finding = from sentence in Sentences
                          from element in sentence.Elements
                          where element is IWord
                          group Sentences.IndexOf(sentence) by element.Value.ToLower() into result
                          select new
                          {
                              name = result.Key,
                              array = result.ToArray().Distinct(),
                              Pair pair = new Pair(result.Count(), array)
                              
                          };

            return finding;
        }
    }
}
