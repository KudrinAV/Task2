using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Contracts.Structs
{
    public struct Pair
    {
        int CountOnText;
        int[] OnWhichPagesMentioned;

        public Pair(int count, int[] mentions)
        {
            CountOnText = count;
            OnWhichPagesMentioned = mentions;
        }
    }
}
