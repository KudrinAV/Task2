using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static void WriteAllText(IText text)
        {
            using (StreamWriter sw = new StreamWriter("../testWriter.txt", false, System.Text.Encoding.Default))
            {

            }
        }
    }
}
