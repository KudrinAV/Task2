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
    }
}
