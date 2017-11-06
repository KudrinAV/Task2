using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.CommonInterfaces.Interfaces;
using Task2.CommonInterfaces.Structs;

namespace Task2.Common.Classes
{
    class Word : IWord
    {
        public int Lenght { get; private set; }

        public bool IsConsonant { get; private set; }

        public string Value { get; private set; }

        private char[] vowels = { 'a', 'e', 'i', 'o', 'u' , 'y'};

        public Word(string value)
        {
            Value = value;
            Lenght = value.Length;
        }

        public void GetIsConsonant()
        {
            foreach(var item in vowels)
            {
                if(Value[0] == item)
                {
                    IsConsonant = true;
                }
            }
        }

        public Symbol ToSymbols()
        {
            Symbol temp = new Symbol(Value);
            return temp;
        }
    }
}
