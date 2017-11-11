﻿using System;
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

            //WriterWorker.WriteSubjectIndex(textAnalyzer.ToPrintList());
            //WriterWorker.WriteAllTextAscByNumberOfWords(text);
            //WriterWorker.WriteAllInterrogativeQuestions(text);

            //foreach (var item in textAnalyzer.SubjectIndex)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //foreach (var item in textAnalyzer.ToPrintList())
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(text.Sentences.ElementAt(10).ToString());
            //text.GetTheSentenceToReplaceWordOnSubString(index: 10, length: 4, subString: " kek lol cheburek i kek, work pls ");
            //Console.WriteLine(text.Sentences.ElementAt(10).ToString());

            //item.ReplaceWordForSubstring(4, "kek lol cheburek i kek, work pls ");
            //Console.WriteLine(item.GetNumberOfWords());
            //Console.WriteLine(item.ToString());
            //Console.WriteLine();




            //foreach (var item in text.Sentences)
            //{
            //    Console.WriteLine(item.GetNumberOfWords());
            //    Console.WriteLine(item.ToString());
            //    item.DeleteWordOnConsonant(4);
            //    Console.WriteLine(item.GetNumberOfWords());
            //    Console.WriteLine(item.ToString());
            //    Console.WriteLine();
            //}

            //}
            //foreach (var item in text.FindWordsInInterrogativeSentences(4))
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in text.ShowAllSentncesSortedByNumberOfWordsAsc())
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //foreach (var item in text.Sentences)
            //{
            //    void kek = item.IsInterrogativeSentence() ? Console.WriteLine(item.ToString()) : Console.WriteLine("hello");
            //}

        }
    }
}
