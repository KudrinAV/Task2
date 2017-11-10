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
        public int Lenght { get; private set; }

        public string Value { get; private set; }

        public Word(string value)
        {
            Value = value;
            Lenght = value.Length;
        }


        public Symbol ToSymbols()
        {
            Symbol temp = new Symbol(Value);
            return temp;
        }
    }
}
