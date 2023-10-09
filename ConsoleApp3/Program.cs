using System;
using System.Text;

class Program
{
    static string DuzgunFormat(string cumle)
    {
        StringBuilder duzgunCumle = new StringBuilder();
        bool kelimeBaslangici = true;

        foreach (char karakter in cumle)
        {
            if (char.IsWhiteSpace(karakter))
            {
          
                kelimeBaslangici = true;
                continue;
            }

            if (kelimeBaslangici)
            {
                
                duzgunCumle.Append(char.ToUpper(karakter));
                kelimeBaslangici = false;
            }
            else
            {
   
                duzgunCumle.Append(char.ToLower(karakter));
            }
        }

        return duzgunCumle.ToString();
    }

    static void Main()
    {
        string inputCumle = "        EverytHing  i neeD,    is a CuP   of       CoFFee    ";
        string outputCumle = DuzgunFormat(inputCumle);

        Console.WriteLine(outputCumle);
    }
}
