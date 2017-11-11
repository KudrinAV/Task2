using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.CommonClasses.ParserObj;
using Task2.CommonClasses.TextAnalyzer;
using Task2.CommonClasses.WriterToFile;
using Task2.Contracts.Interfaces;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Parser myParser = new Parser();
            IText text = new CommonClasses.TextObjects.Text();
            text = myParser.ParseText(@"..\test.txt");

            ITextAnalyzer textAnalyzer = new TextAnalyzer(text.FindAllWords());

            IText textForSubjectIndex = myParser.ParseTextForTask2(@"../test.txt");

            //WriterWorker.WriteSubjectIndex(textAnalyzer.ToPrintList());
            //WriterWorker.WriteAllTextAscByNumberOfWords(text);
            //WriterWorker.WriteAllInterrogativeSentence(text);
            //WriterWorker.WriteAllWordsInInterrogativeSentences(text, 5);
            //WriterWorker.WriteTextWithoutWordOfSetLength(text, 4);
            //WriterWorker.WriteSentenceThatReplacedWordToSubstring(text, 0, 3, "this is new replaced, reddit did it not me");

            ITextAnalyzer textAnalyzerForLines = new TextAnalyzer(textForSubjectIndex.FindAllWords());
            foreach(var item in textAnalyzerForLines.ToPrintList())
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
