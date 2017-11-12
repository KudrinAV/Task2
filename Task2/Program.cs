using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.CommonClasses.ParserObj;
using Task2.CommonClasses.TextAnalyzer;
using Task2.Contracts.Interfaces;
using Task2.Contracts.WriterToFile;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Parser myParser = new Parser();
            IText text = new CommonClasses.TextObjects.Text();
            text = myParser.ParseText(@"..\testToEdit.txt");

            ITextAnalyzer textAnalyzer = new TextAnalyzer(text.FindAllWords());

            //WriterWorker.WriteToFileFlexible(iterator: text.FindWordsInInterrogativeSentences(4), path: "../textFlexibleWordsInInterrogativeSentences.txt");
            //WriterWorker.WriteToFileFlexible(iterator: text.ShowAllSentncesSortedByNumberOfWordsAsc(), path: "../textFlexibleAllSentencesSortedByNumberOfWordsAsc.txt");
            //WriterWorker.WriteToFileFlexible(iterator: text.DeleteWordsOnConsonantByLength(4), path: "../textFlexibaleDeletedWordOnConsonant.txt");
            //WriterWorker.WriteToFileFlexible(iterator: text.)
            //WriterWorker.WriteToFileFlexible(iterator: text.GetTheSentenceToReplaceWordOnSubString(index: 0, length: 4, subString: "THIS IS NEW REPLACEMENT, THANK YOU "), path: "../textFLexTestWordToSubString");

            //WriterWorker.WriteSubjectIndex(textAnalyzer.ToPrintList());
            WriterWorker.WriteAllInterrogativeSentence(text);
            //WriterWorker.WriteTextWithoutWordOfSetLength(text, 5);
            WriterWorker.WriteSentenceThatReplacedWordToSubstring(text: text, index: 0, lenght: 4, subString: "THIS IS NEW REPLACEMENT, THANK YOU ");


            //IText textForSubjectIndex = myParser.ParseTextForTask2(@"../test.txt");
            //ITextAnalyzer textAnalyzerForLines = new TextAnalyzer(textForSubjectIndex.FindAllWords(), 10);
            //WriterWorker.WriteSubjectIndexForPages(textAnalyzerForLines.ToPrintListForPages());
        }
    }
}
