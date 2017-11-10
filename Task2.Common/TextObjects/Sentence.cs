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
        private char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };

        public List<ISentenceElement> Elements { get; private set; }

        public int GetNumberOfWords()
        {
            var count = Elements.Where(x => x is IWord).Count();
            return count;
        }


        public void ReplaceWordForSubstring(int length)
        {
            throw new NotImplementedException();
        }

        public bool IsInterrogativeSentence()
        {
            return Elements.Last().Value.Contains("?");
        }

        public Sentence()
        {
            Elements = new List<ISentenceElement>();
        }

        public override string ToString()
        {
            string resultString = null;
            foreach(var item in Elements)
            {
                resultString = item != Elements.First() ? item is IWord ? resultString += " " + item.Value : resultString += item.Value : resultString += item.Value;
            }
            return resultString;
        }

        private IEnumerable<ISentenceElement> FindWordOnConsonant(int length)
        {
            var finding = from element in Elements
                          group element by element is IWord && element.Value.Length == length && IsAVowel(element.Value.ToLower().First()) into wordGroup
                          where wordGroup.Key
                          from word in wordGroup
                          select word;
            return finding;
        }

        public void DeleteWordOnConsonant(int length)
        {
            foreach (var item in FindWordOnConsonant(length))
            {
                Elements.Remove(item);
            }
        }

        private bool IsAVowel(char letter)
        {
            foreach (var item in vowels)
            {
                if (letter == item)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
