using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Contracts.Interfaces;
using Task2.Contracts.Structs;

namespace Task2.CommonClasses.TextAnalyzer
{
    public class TextAnalyzer : ITextAnalyzer
    {
        public Dictionary<string, Pair> SubjectIndex { get; private set; }
       

        public TextAnalyzer(IEnumerable<IGrouping<string, int>> data)
        {
            SubjectIndex = new Dictionary<string, Pair>();
            foreach (var item in data)
            {
                SubjectIndex.Add(item.Key, new Pair(item.Count(), item.Distinct().ToArray()));
            }
        }
        

        public List<string> ToPrintList()
        {
            List<string> strList = new List<string>();
            foreach (var item in SubjectIndex)
            {
                strList.Add(String.Format("{0,-20}{1,-50}", item.Key, item.Value.ToString()));
            }

            return strList;
        }
    }
}
