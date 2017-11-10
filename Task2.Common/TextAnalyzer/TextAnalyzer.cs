using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Contracts.Interfaces;

namespace Task2.CommonClasses.TextAnalyzer
{
    public class TextAnalyzer : ITextAnalyzer
    {
        public Dictionary<string, Dictionary<int, int[]>> Dictionary => throw new NotImplementedException();
    }
}
