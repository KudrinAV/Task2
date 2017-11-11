using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Contracts.Structs;

namespace Task2.Contracts.Interfaces
{
    public interface IText
    {
        List<ISentence> Sentences { get; }
        
        IEnumerable<string> FindWordsInInterrogativeSentences(int length);
        IEnumerable<ISentence> ShowAllSentncesSortedByNumberOfWordsAsc();
        ISentence GetTheSentenceToReplaceWordOnSubString(int index, int length, string subString);
        IEnumerable<IGrouping<string, int>> FindAllWords();
        List<ISentence> DeleteWordsOnConsonantByLength(int length);
    }
}
