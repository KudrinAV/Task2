using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Contracts.Interfaces;

namespace Task2.Contracts.WriterToFile
{
    public static class WriterWorker
    {
        public static void WriteAllTextBySentences(IText text)
        {
            using (StreamWriter sw = new StreamWriter("../AllTextBySentences.txt", false, System.Text.Encoding.Default))
            {
                foreach (var item in text.Sentences)
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

       public static void WriteSentenceThatReplacedWordToSubstring(IText text, int index, int lenght, string subString)
        {
            using (StreamWriter sw = new StreamWriter("../testReplacedWordToSubString.txt", false, System.Text.Encoding.Default))
            {
                sw.WriteLine(text.Sentences.ElementAt(index).ToString());
                sw.WriteLine(string.Empty);
                sw.WriteLine(text.GetTheSentenceToReplaceWordOnSubString(index, lenght, subString));
            }
        } 

        public static void WriteToFileFlexible(IEnumerable iterator, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                foreach(var item in iterator)
                {
                    sw.WriteLine(item.ToString());
                }
            }
        }
    }
}
