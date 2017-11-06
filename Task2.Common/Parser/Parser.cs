using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.CommonInterfaces.Interfaces;
using Task2.CommonInterfaces.ParserInterfaces;
using Task2.Common.TextObjects;

namespace Task2.Common.Parser
{
    public class Parser : IParser
    {
        public ISentence SentenceParser(string sentence)
        {
            throw new NotImplementedException();
        }

        public IText TextParser(StreamReader streamReader)
        {
            IText parsingText = new Text();
            string line;
            string notFinishedSentence = null;

            try
            {
                while ((line = streamReader.ReadLine()) != null)
                {
                    parsingText.
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

            return parsingText;
        }
    }
}
