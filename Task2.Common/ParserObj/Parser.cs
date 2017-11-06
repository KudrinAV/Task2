using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.CommonInterfaces.Interfaces;
using Task2.CommonInterfaces.ParserInterfaces;
using Task2.CommonClasses.TextObjects;
using System.Text.RegularExpressions;

namespace Task2.CommonClasses.ParserObj
{
    public class Parser : IParser
    {
        private Regex _lineToSentences = new Regex(@"([A-Z]{1}[a-zA-Z\d\s\-\,\']+[\.\?\!]{3})|([A-Z]{1}[a-zA-Z\d\s\-\,\']+[(\?\!)]{2})|([A-Z]{1}[a-zA-Z\d\s\-\,\']+[\.\!\?]{1})");

        public ISentence SentenceParser(string sentence)
        {
            throw new NotImplementedException();
        }

        public IText TextParser(StreamReader streamReader)
        {
            IText parsingText = new Text();
            List<string> learningRegex = new List<string>();
            string line;
            string notFinishedSentence = null;

            try
            {
                while ((line = streamReader.ReadLine()) != null)
                {
                    var sentences = _lineToSentences.Split(line).Select(x=>Regex.Replace(x.Trim(),@"\s+",@" ")).ToArray();
                    bool sentce = _lineToSentences.IsMatch(line);
                    foreach (var item in sentences)
                    {
                        if(item != "") learningRegex.Add(item);
                    }
                    Console.WriteLine(sentce);
                    
                    //parsingText.Sentences.Add(var);
                }
                

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Data.ToString());
                streamReader.Close();
            }
            finally
            {
                streamReader.Close();
                streamReader.Dispose();
            }

            foreach(var item in learningRegex)
            {
                if(item != "")                Console.WriteLine(item);
            }
            return parsingText;
        }
    }
}
