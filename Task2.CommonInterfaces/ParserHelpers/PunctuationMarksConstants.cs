using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.CommonClasses.ParserHelpers
{
    public static class PunctuationMarksConstants
    {
        public static string[] QuotesMarks = { "\"", "'" };

        public static string[] EndSentenceMarks = { ".", "?", "!", "!?", "?!", "...", "!!!", "???" };

        public static string[] SeparatingSentenceMarks = { ",", ";", ":" };

        public static string[] OpenBraketsMarks = { "[", "(", "{" };

        public static string[] CloseBraketsMarks = { "]", ")" , "}"};

        public static string[] AllSentenceMarks = { "...", "!!!", "???", "\"", ".", "?", "!", "!?", "?!", "'", ",", ";", ":", "[", "(", "{", "]", ")", "}" };
    }
}
