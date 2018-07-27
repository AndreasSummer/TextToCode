using System;
using System.Collections.Generic;

namespace SummerAndi.TextToCodeLogic.Patterns
{
    public class TextReplaceMutliLine : IReplacePattern
    {
        public TextReplaceMutliLine()
        {
        }

        public string NewLinePattern { get; set; } = "\r\n";
        public string PatternDescription { get => "TextReplaceMutliLine"; }
        public string NameOfPattern { get => "TextReplaceMutliLine"; }

        public string Convert(string inputString, string patternString)
        {
            var x = CreateListFromString(inputString);
            return OutputFromText(patternString, x);
        }


        public List<string> CreateListFromString(string inputText)
        {
            List<string> list = new List<string>(
                           inputText.Split(new string[] { NewLinePattern },
                           StringSplitOptions.RemoveEmptyEntries));


            return list;
        }


        public string OutputFromText(string template, List<string> fillText)
        {
            var sb = new System.Text.StringBuilder();
            foreach (var item in fillText)
            {
                sb.AppendLine(template.Replace("{placeholder}", item));
            }

            return sb.ToString();
        }
    }
}
