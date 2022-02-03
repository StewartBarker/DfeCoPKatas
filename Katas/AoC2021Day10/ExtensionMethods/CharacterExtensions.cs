using System.Collections;

namespace AoC2021Day10.ExtensionMethods;

public static class CharacterExtensions
{
    public static bool IsOpeningParenthesis (this char c)  => ((IList)new[] { '{', '[', '(', '<' }).Contains(c);
    
    public static char MatchingOpeningParenthesis(this char closingParenthesis)
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