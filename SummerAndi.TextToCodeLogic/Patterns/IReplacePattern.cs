namespace SummerAndi.TextToCodeLogic.Patterns
{
    public interface IReplacePattern
    {
        string NameOfPattern { get; }

        string NewLinePattern { get; set; }

        string PatternDescription { get; }

        string Convert(string inputString, string patternString);
    }
}