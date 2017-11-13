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
                          where sentence.IsInterrogativeSentence()  
                          from element in sentence.Elements
                          group element by element is IWord && element.Value.Length == length into wordGroup
                          where wordGroup.Key
                          from word in wordGroup
                          group word by word.Value.ToLower() into result
                          select result.Key;

            return finding;
        }

        public ISentence GetTheSentenceToReplaceWordOnSubString(int index, int length, string subString)
        {
            ISentence resultSentence = Sentences.ElementAt(index);
            resultSentence.ReplaceWordForSubstring(length, subString);
            return resultSentence;
        }

        public IEnumerable<ISentence> ShowAllSentncesSortedByNumberOfWordsAsc()
        {
            var sort = Sentences.OrderBy(x => x.GetNumberOfWords());
            return sort;
        }

        public Text(List<ISentence> sentences)
        {
            Sentences = sentences;
        }

        public IEnumerable<IGrouping<string, int>> FindAllWords()
        {
            var finding = from sentence in Sentences
                          from element in sentence.Elements
                          where element is IWord
                          group Sentences.IndexOf(sentence) by element.Value.ToLower() into result
                          select result;

            return finding;
        }

        public List<ISentence> DeleteWordsOnConsonantByLength(int length)
        {
            List<ISentence> resultList = Sentences;
            foreach (var item in resultList)
            {
                item.DeleteWordOnConsonant(length);
            }

            return resultList;
        }
    }
}
