using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Contracts.Structs
{
    public struct Symbol
    {
        Char[] Chars;

        public Symbol(string chars)
        {
            Chars = chars.ToCharArray();
        }
    }
}
