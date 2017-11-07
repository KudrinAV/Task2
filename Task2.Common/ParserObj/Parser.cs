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

        private Regex _sentenceToElements = new Regex(@"(\[)|(\w)|(\"")|(\])|(\~)");


        public ISentence SentenceParser(string sentence)
        {
            var resultSentence = new Sentence();

            Func<string, ISentenceElement> toISentenceElement =
                item => !PunctuationMarksHelper.AllSentenceMarks.Contains(item) ? (ISentenceElement)new Word(item) : (ISentenceElement)new PunctuationMark(item);

            foreach(Match item in _sentenceToElements.Matches(sentence))
            {
                for(int i = 0; i< item.Groups.Count; i++)
                {
                    if (item.Groups[i].Value.Trim() != "")
                    {
                        resultSentence.Elements.Add(toISentenceElement(item.Groups[i].Value.Trim()));
                        Console.WriteLine(item.Groups[i].Value.Trim());
                    }
                }
            }

            return resultSentence;
        }

        public IText TextParser(StreamReader streamReader)
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
                            notFinishedSentence = sentences.Last();
                            foreach (var item in sentences)
                            {
                                if (item != "" && item != sentences.Last())
                                {
                                    learningRegex.Add(item);
                                }
                            }
                        }
                        else
                        {
                            resultText.Sentences.AddRange(sentences.Select(SentenceParser));
                            notFinishedSentence = null;
                            foreach (var item in sentences)
                            {
                                if (item != "" ) learningRegex.Add(item);
                            }
                        }

                        //parsingText.Sentences.Add(var);
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
            foreach (var item in learningRegex)
            {
                Console.WriteLine(item);
            }
            return resultText;
        }
    }
}
