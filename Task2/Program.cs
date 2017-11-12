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

            //Task 1

            //WriterWorker.WriteToFileFlexible(iterator: text.Sentences, path: "../textFlexAllTextBySentences.txt");
            //WriterWorker.WriteToFileFlexible(iterator: text.FindWordsInInterrogativeSentences(4), path: "../textFlexibleWordsInInterrogativeSentences.txt");
            //WriterWorker.WriteToFileFlexible(iterator: text.ShowAllSentncesSortedByNumberOfWordsAsc(), path: "../textFlexibleAllSentencesSortedByNumberOfWordsAsc.txt");
            //WriterWorker.WriteToFileFlexible(iterator: text.DeleteWordsOnConsonantByLength(4), path: "../textFlexibaleDeletedWordOnConsonant.txt");
            //WriterWorker.WriteSentenceThatReplacedWordToSubstring(sentence: text.GetTheSentenceToReplaceWordOnSubString(index: 0, length: 5, subString: "THIS IS NEW REPLACEMENT, THANK YOU "), path: "../textWordToSubString.txt");
            
            //Task 2

            //IText textForSubjectIndex = myParser.ParseTextForTask2(@"../testToEdit.txt");
            //ITextAnalyzer textAnalyzerForLines = new TextAnalyzer(textForSubjectIndex.FindAllWords(), 10);
            //WriterWorker.WriteToFileFlexible(textAnalyzerForLines.ToPrintListForPages(), path: "../testFlexibleSubjectIndexForPages.txt");
            //WriterWorker.WriteToFileFlexible(textAnalyzerForLines.ToPrintListForSentences(), path: "../testFlexibleSubjectindexForSentences.txt");
            //textForSubjectIndex = myParser.ParseTextForTask2(@"../testPiper.txt");
            //textAnalyzerForLines = new TextAnalyzer(textForSubjectIndex.FindAllWords());
            //WriterWorker.WriteToFileFlexible(textAnalyzerForLines.ToPrintListForSentences(), path: "../testFlexibleSubjectindexForSentencesPiper.txt");
        }
    }
}
