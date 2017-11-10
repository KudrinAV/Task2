﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.CommonClasses.ParserObj;
using Task2.CommonInterfaces.Interfaces;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Parser myParser = new Parser();
            StreamReader streamReader = new StreamReader(@"..\test.txt");
            IText text = new CommonClasses.TextObjects.Text();
            text = myParser.ParseText(streamReader);

            text.DeleteWordOnConsonant(3);
            //foreach(var item in text.FindWordsInInterrogativeSentences(4))
            //{
            //    Console.WriteLine(item);
            //}
            //foreach(var item in text.ShowAllSentncesSortedByNumberOfWordsAsc())
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //foreach (var item in text.Sentences)
            //{
            //    Console.WriteLine(item.IsInterrogativeSentence());
            //    Console.WriteLine(item.GetNumberOfWords());
            //    foreach (var temp in item.Elements)
            //    {
            //        Console.Write(temp.Value + "  ");
            //    }
            //    Console.WriteLine();
            //}

        }
    
    }
}
