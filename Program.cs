for (int i = 1; i < 3999; i++)
    Console.WriteLine(i + " = " + intToRoman(i));

static string intToRoman(int x)
{
    string[] romans = new string[] { "I", "V", "X", "L", "C", "D", "M" };
    string s = x.ToString();
    string romanNumber = string.Empty;

    for (int i = 0; i < s.Length; i++)
    {
        int cifra = (int)s[i];
        int index = romans.Length - (2 * i) - 1 - ((4 - s.Length) * 2);

        if (cifra > 48 && cifra < 52)
            for (int j = 48; j < cifra; j++)
                romanNumber += romans[index];
        else if (cifra == 52)
            romanNumber += romans[index] + romans[index + 1];
        else if (cifra > 52 && cifra < 57)
        {
            romanNumber += romans[index + 1];
            for (int j = 53; j < cifra; j++)
                romanNumber += romans[index];
        }
        else if (cifra == 57)
            romanNumber += romans[index] + romans[index + 2];
    }

    return romanNumber;
}