using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.CommonClasses.ParserHelpers;
using Task2.Contracts.Interfaces;
using Task2.Contracts.Structs;

namespace Task2.CommonClasses.TextObjects
{
    public class PunctuationMark : IPunctuationMark
    {
        public bool IsEndMark()
        {
            return !PunctuationMarksConstants.EndSentenceMarks.Contains(Value);
        }

        public string Value { get; private set; }

        public PunctuationMark(string value)
        {
            Value = value;
        }

        public int GetIndexOfLine(ISentence current)
        {
            return current.IndexOfLine;
        }

        public Symbol ToSymbols()
        {
            Symbol temp = new Symbol(Value);
            return temp;
        }
    }
}
