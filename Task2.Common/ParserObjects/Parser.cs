using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Contracts.Interfaces;
using Task2.Contracts.ParserInterfaces;
using Task2.CommonClasses.TextObjects;
using System.Text.RegularExpressions;
using Task2.CommonClasses.ParserHelpers;
using Task2.Contracts.ParserHelpers;

namespace Task2.CommonClasses.ParserObj
{
    public class Parser : IParser
    {
        private Regex _lineToSentences = new Regex(@"([\w\s-,'~:;\[\]\(\)\{\}]+[\.\?!]{1,3})");

        private Regex _sentenceToElements = new Regex(@"(\[)|([\w']+)|([\d]+)|(\"")|(,)|([\[\]\(\)\{\}])|([,-:~;']{1})|([\.\!\?]{1,3})");


        public ISentence ParseSentence(string sentence)
        {
            var resultSentence = new Sentence();

            Func<string, ISentenceElement> toISentenceElement =
                item => !PunctuationMarksConstants.AllSentenceMarks.Contains(item) && !DigitConstants.Digits.Contains(item.First().ToString()) ? (ISentenceElement)new Word(item) 
                                                                                : !PunctuationMarksConstants.AllSentenceMarks.Contains(item) ? (ISentenceElement)new Digit(item)  
                                                                                                                                : (ISentenceElement)new PunctuationMark(item);

            foreach (Match item in _sentenceToElements.Matches(sentence))
            {
                resultSentence.Elements.Add(toISentenceElement(item.Value.Trim()));
            }

            return resultSentence;
        }


        public IText ParseText(string path)
        {
            IText resultText = new Text();
            string line;
            string notFinishedSentence = null;

            using (StreamReader streamReader = new StreamReader(path))
            {
                try
                {
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (Regex.Replace(line.Trim(), @"\s+", @" ") != string.Empty)
                        {
                            line = notFinishedSentence + " " + line;

                            var sentences = _lineToSentences.Split(line).Select(x => Regex.Replace(x.Trim(), @"\s+", @" ")).ToArray();

                            if (sentences.Last() != string.Empty)
                            {
                                resultText.Sentences.AddRange(sentences.Where(x => x != sentences.Last() && x != string.Empty).Select(ParseSentence));
                                notFinishedSentence = sentences.Last();
                            }
                            else
                            {
                                resultText.Sentences.AddRange(sentences.Where(x => x != string.Empty).Select(ParseSentence));
                                notFinishedSentence = null;
                            }
                        }
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Data.ToString());
                }
            }
            return resultText;
        }

        public IText ParseTextForTask2(string path)
        {
            IText resultText = new Text();
            string line;

            using (StreamReader streamReader = new StreamReader(path))
            {
                try
                {
                    int indexOfLine = 0;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        resultText.Sentences.Add(ParseSentence(line));
                        resultText.Sentences.Last().SetIndexOfLine(indexOfLine);
                        indexOfLine++;
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Data.ToString());
                }
            }
            return resultText;
        }

    }
}
