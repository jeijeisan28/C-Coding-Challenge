
using System;
using System.Collections.Generic;
using System.Text;

public class OldPhone
{
    private static readonly Dictionary<char, string> keypad = new Dictionary<char, string>
    {
        { '1', "&'(" },
        { '2', "ABC" },
        { '3', "DEF" },
        { '4', "GHI" },
        { '5', "JKL" },
        { '6', "MNO" },
        { '7', "PQRS" },
        { '8', "TUV" },
        { '9', "WXYZ" },
        { '0', " " }
    };

    public static string OldPhonePad(string input)
    {
        StringBuilder output = new StringBuilder();
        StringBuilder currentSequence = new StringBuilder();

        char? lastChar = null;

        foreach (char c in input)
        {
            if (c == '#')
            {
                AppendCurrentSequence(output, currentSequence, lastChar);
                break;
            }
            else if (c == '*')
            {
                AppendCurrentSequence(output, currentSequence, lastChar);
                if (output.Length > 0)
                    output.Length -= 1;
            }
            else if (c == ' ')
            {
                AppendCurrentSequence(output, currentSequence, lastChar);
            }
            else if (char.IsDigit(c))
            {
                if (lastChar == c)
                {
                    currentSequence.Append(c);
                }
                else
                {
                    AppendCurrentSequence(output, currentSequence, lastChar);
                    currentSequence.Append(c);
                    lastChar = c;
                }
            }
        }

        return output.ToString();
    }

    private static void AppendCurrentSequence(StringBuilder output, StringBuilder sequence, char? key)
    {
        if (sequence.Length > 0 && key != null && keypad.ContainsKey(key.Value))
        {
            string letters = keypad[key.Value];
            int index = (sequence.Length - 1) % letters.Length;
            output.Append(letters[index]);
        }
        sequence.Clear();
    }
}
