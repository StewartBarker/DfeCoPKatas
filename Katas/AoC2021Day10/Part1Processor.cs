using System.Collections;

namespace AoC2021Day10;

public static class Part1Processor
{
    public static int Execute(string[] data)
    {
        var characterStack = new Stack();
        var score = 0;
        foreach (var line in data)
        {
            foreach (var character in line)
            {
                if (IsOpeningParenthesis(character))
                {
                    characterStack.Push(character);
                }
                else
                {
                    var expected = GetMatchingOpeningParenthesis(character);
                    var actual = (char)characterStack.Pop();
                    if (actual != expected)
                    {
                        score += GetCharacterScore(expected);
                        break;
                    }
                }
            }
        }
        
        bool IsOpeningParenthesis(char c) => ((IList)new[] { '{', '[', '(', '<' }).Contains(c);
        
        return score;
    }

    private static int GetCharacterScore(char openingParenthesis)
    {
        return openingParenthesis switch
        {
            '(' => 3,
            '[' => 57,
            '{' => 1197,
            '<' => 25137,
            _ => throw new ArgumentOutOfRangeException(nameof(openingParenthesis), $"{openingParenthesis} is an invalid character")
        };
    }

    private static char GetMatchingOpeningParenthesis(char closingParenthesis)
    {
        return closingParenthesis switch
        {
            ']' => '[',
            '}' => '{',
            ')' => '(',
            '>' => '<',
            _ => throw new ArgumentOutOfRangeException(nameof(closingParenthesis), $"Can't find matching opening parenthesis for '{closingParenthesis}'")
        };
    }
}