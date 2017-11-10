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

        public override string ToString()
        {
            string str = CountOnText.ToString()+":";
            for(int i=0; i<OnWhichPagesMentioned.Count(); i++)
            {
                str += " " + (OnWhichPagesMentioned[i] + 1).ToString();
            }
            return str;
        }

    }
}
