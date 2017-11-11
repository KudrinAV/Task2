using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Contracts.Interfaces;

namespace Task2.CommonClasses.WriterToFile
{
    public static class WriterWorker
    {
        public static void WriteSubjectIndex(List<string> list)
        {
            using (StreamWriter sw = new StreamWriter("../testWriter.txt", false, System.Text.Encoding.Default))
            {
                foreach (var item in list)
                {
                    sw.WriteLine(item);
                }
            }
        }

        public static void WriteAllTextAscByNumberOfWords(IText text)
        {
            using (StreamWriter sw = new StreamWriter("../testAllWriter.txt", false, System.Text.Encoding.Default))
            {
                foreach(var item in text.ShowAllSentncesSortedByNumberOfWordsAsc())
                {
                    sw.WriteLine(item.ToString());
                }
            }
        }

        public static void WriteAllInterrogativeSentence(IText text)
        {
            using (StreamWriter sw = new StreamWriter("../testAllInterrogativeSentence.txt", false, System.Text.Encoding.Default))
            {
                foreach (var item in text.Sentences)
                {
                    if(item.IsInterrogativeSentence()) sw.WriteLine(item.ToString());
                }
            }
        }

        public static void WriteAllWordsInInterrogativeSentences(IText text, int length)
        {
            using (StreamWriter sw = new StreamWriter("../testAllWordsInInterrogativeSentenceByNumber.txt", false, System.Text.Encoding.Default))
            {
                foreach (var item in text.FindWordsInInterrogativeSentences(length))
                {
                    sw.WriteLine(item);
                }
            }
        }

        public static void WriteTextWithoutWordOfSetLength(IText text, int lenght)
        {
            using (StreamWriter sw = new StreamWriter("../testWithoutWordsOnConsonantOfSet.txt", false, System.Text.Encoding.Default))
            {
                foreach (var item in text.DeleteWordsOnConsonantByLength(lenght))
                {
                    sw.WriteLine(item);
                }
            }
        }

       //public static void 
    }
}
