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
using Task2.CommonClasses.ParserHelpers;
using Task2.CommonClasses.Classes;

namespace Task2.CommonClasses.ParserObj
{
    public class Parser : IParser
    {
        private Regex _lineToSentences = new Regex(@"([\w\s\-\,\'\~\:\(\)\""]+[\.\?\!]{3})|([\w\s\-\,\'\~\:\(\)\""]+[(\?\!)]{2})|([\w\s\-\,\'\~\:\(\)\""]+[\.\!\?]{1})");

        private Regex _sentenceToElements = new Regex(@"(\[)|(\w+)|(\"")|(\])|(\~)|([\.\!\?]{3)|([\!\?]{2})|([\.\!\?]{1})");

    
        public ISentence ParseSentence(string sentence)
        {
            var resultSentence = new Sentence();

            Func<string, ISentenceElement> toISentenceElement =
                item => !PunctuationMarksHelper.AllSentenceMarks.Contains(item) ? (ISentenceElement)new Word(item) : (ISentenceElement)new PunctuationMark(item);

            foreach(Match item in _sentenceToElements.Matches(sentence))
            {
                resultSentence.Elements.Add(toISentenceElement(item.Value.Trim()));
            }
            
            return resultSentence;
        }

        public IText ParseText(StreamReader streamReader)
        {
            IText resultText = new Text();
            List<string> learningRegex = new List<string>();
            string line;
            string notFinishedSentence = null;

            try
            {
                
                while ((line = streamReader.ReadLine()) != null)
                { 
                    if (Regex.Replace(line.Trim(), @"\s+", @" ") != "")
                    {
                        
                        line = notFinishedSentence + line;

                        var sentences = _lineToSentences.Split(line).Select(x => Regex.Replace(x.Trim(), @"\s+", @" ")).ToArray();
                        
                        if(sentences.Last() != "")
                        {
                            resultText.Sentences.AddRange(sentences.Where(x => x != sentences.Last()).Select(ParseSentence));
                            notFinishedSentence = sentences.Last();
                            }
                        else
                        {
                            resultText.Sentences.AddRange(sentences.Select(ParseSentence));
                            notFinishedSentence = null;
                        }
                    }
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
            Console.WriteLine();
            return resultText;
        }
    }
}
