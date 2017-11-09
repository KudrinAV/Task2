﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.CommonClasses.ParserObj;
using Task2.CommonInterfaces.Interfaces;

namespace Task2.CommonClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser myParser = new Parser();
            StreamReader streamReader = new StreamReader(@"test.txt");
            IText text = new TextObjects.Text();
            text = myParser.TextParser(streamReader);
            foreach(var item in text.Sentences)
            {
                foreach(var temp in item.Elements)
                {
                    Console.Write(temp.Value + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
