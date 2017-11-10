using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.CommonInterfaces.Interfaces
{
    public interface IText
    {
        List<ISentence> Sentences { get; }
        
        IEnumerable<string> FindWordsInInterrogativeSentences(int length);
        IEnumerable<ISentence> ShowAllSentncesSortedByNumberOfWordsAsc();
        void GetTheSentenceToReplaceWordOnSubString(int index, int length, string subString);
    }
}
