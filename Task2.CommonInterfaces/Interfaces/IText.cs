﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.CommonInterfaces.Interfaces
{
    public interface IText
    {
        List<ISentence> Text { get; }
        

        void DeleteWordOnConstatnt(int length);
        void FindWordsInInterrogativeSentences(int length);

    }
}
