using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Contracts.Structs;

namespace Task2.Contracts.Interfaces
{
    public interface ITextAnalyzer
    {
        Dictionary<string, Pair> SubjectIndex { get; }

        List<string> ToPrintList();
        
    }
}
