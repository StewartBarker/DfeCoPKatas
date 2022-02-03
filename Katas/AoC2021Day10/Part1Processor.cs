using System.Collections;
using AoC2021Day10.ExtensionMethods;

namespace AoC2021Day10;

public static class Part1Processor
{
    public static int Execute(string[] data)
    {
        var characterStack = new Stack<char>();
        var score = 0;
        foreach (var line in data)
        {
            foreach (var character in line)
            {
                if (character.IsOpeningParenthesis())
                {
                    characterStack.Push(character);
                }
                else
                {
                    var expected = character.MatchingOpeningParenthesis();
                    var actual = characterStack.Count > 0 ? characterStack.Pop() : (char?)null;
                    if (actual != expected)
                    {
                        score += GetCharacterScore(expected);
                        break;
                    }
                }
            }
        }

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
            _ => throw new ArgumentOutOfRangeException(nameof(openingParenthesis),
                $"{openingParenthesis} is an invalid character")
        };
    }
}