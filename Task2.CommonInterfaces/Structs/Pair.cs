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
        int[] OnWhichLinesMentioned;

        public Pair(int count, int[] mentions)
        {
            CountOnText = count;
            OnWhichLinesMentioned = mentions;
        }

        public override string ToString()
        {
            string str = CountOnText.ToString()+":";
            for(int i=0; i<OnWhichLinesMentioned.Count(); i++)
            {
                str += " " + (OnWhichLinesMentioned[i] + 1).ToString();
            }
            return str;
        }

        public string ToString(int page)
        {
            string str = CountOnText.ToString() + ":";
            int[] pages = OnPage(page);
            for (int i = 0; i < pages.Count(); i++)
            {
                str += " " + pages[i];
            }
            return str;
        }

        public int[] OnPage(int page)
        {
            int[] pages = new int[OnWhichLinesMentioned.Count()];
            for(int i=0; i<OnWhichLinesMentioned.Count(); i++)
            {
                pages[i] = (OnWhichLinesMentioned[i] + 1) / page +1 ;
            }
            return pages.Distinct().ToArray();
        }
    }
}
