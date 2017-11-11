﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Contracts.Interfaces;
using Task2.Contracts.Structs;

namespace Task2.CommonClasses.Classes
{
    public class PunctuationMark : IPunctuationMark
    {
        public bool IsEndMark { get; private set; }

        public string Value { get; private set; }

        public int IndexOfLine { get; private set; }

        public PunctuationMark(string value)
        {
            Value = value;
        }

        public PunctuationMark(string value, int indexOfLine)
        {
            Value = value;
            IndexOfLine = indexOfLine;
        }

        public Symbol ToSymbols()
        {
            Symbol temp = new Symbol(Value);
            return temp;
        }
    }
}
