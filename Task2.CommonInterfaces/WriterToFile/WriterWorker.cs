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
        public static void WriteAllInterrogativeSentence(IText text)
        {
            using (StreamWriter sw = new StreamWriter("../testAllInterrogativeSentence.txt", false, System.Text.Encoding.Default))
            {
                foreach (var item in text.Sentences)
                {
                    if (item.IsInterrogativeSentence()) sw.WriteLine(item.ToString());
                }
            }
        }

        public static void WriteSentenceThatReplacedWordToSubstring(ISentence sentence, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(sentence.ToString());
            }
        }

        public static void WriteToFileFlexible(IEnumerable iterator, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                foreach (var item in iterator)
                {
                    sw.WriteLine(item.ToString());
                }
            }
        }
    }
}
