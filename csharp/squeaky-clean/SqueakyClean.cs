using System;
using System.Text;
using System.Text.RegularExpressions;

//@kberg's solution
public static class Identifier
{
    public static string Clean(string identifier)
    {
        var newString = new StringBuilder("",identifier.Length);

        for (var i = 0; i < identifier.Length; i++)
        {
            char character = identifier[i];
            if (char.IsWhiteSpace(character))
            {
                newString.Append('_');
            }
            else if (char.IsControl(character))
            {
                newString.Append("CTRL");
            }
            else if (character == '-')
            {
                char upperCase = char.ToUpper(identifier[i + 1]);
                newString.Append(upperCase);
                i += 1;
            }
            string greekLetters = "αβγδεζηθικλμνξοπρστυϕχψω";
            bool isGreekLetter = false;

            for (var j = 0; j < greekLetters.Length; j++)
            {
                if (character == greekLetters[j])
                {
                    isGreekLetter = true;
                    break;
                }
            }
            if (char.IsLetter(character) && !isGreekLetter)
            {
                newString.Append(character);
            }
        }

        return newString.ToString();

    }
}
