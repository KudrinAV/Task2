using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Contracts.Interfaces;
using Task2.Contracts.Structs;

namespace Task2.CommonClasses.Classes
{
    public class Word : IWord
    {
        private char[] _vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
        
        public int Lenght { get; private set; }

        public string Value { get; private set; }

        public int IndexOfLine { get; private set; }

        public Word(string value)
        {
            Value = value;
            Lenght = value.Length;
        }

        public Word(string value, int indexOfLine)
        {
            Value = value;
            Lenght = value.Length;
            IndexOfLine = indexOfLine;
        }

        public bool IsAVowel()
        {
            foreach(var item in _vowels)
            {
                if (Value.ToLower().First() == item)
                {
                    return true;
                }
            }
            return false;
        }

        public Symbol ToSymbols()
        {
            Symbol temp = new Symbol(Value);
            return temp;
        }
    }
}
