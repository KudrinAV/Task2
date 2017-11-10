using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Contracts.Interfaces
{
    public interface ITextAnalyzer
    {
        Dictionary<string, Dictionary<int, int[]>> Dictionary { get; }


    }
}
