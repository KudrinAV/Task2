using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.CommonClasses.ParserObj;


namespace Task2.CommonClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser myParser = new Parser();
            StreamReader streamReader = new StreamReader(@"test.txt");

            myParser.TextParser(streamReader);
        }
    }
}
