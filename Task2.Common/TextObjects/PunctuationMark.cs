using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.CommonInterfaces.Interfaces;
using Task2.CommonInterfaces.Structs;

namespace Task2.CommonClasses.Classes
{
    public class PunctuationMark : IPunctuationMark
    {
        public bool IsItEndMark => throw new NotImplementedException();

        public Symbol Symbols => throw new NotImplementedException();

        public string Value => throw new NotImplementedException();

        public PunctuationMark(string value)
        {

        }
    }
}
