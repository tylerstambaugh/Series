

using System.ComponentModel.DataAnnotations.Schema;
/// <summary>
/// https://exercism.org/tracks/csharp/exercises/series
/// </summary>
/// 

string[] test = Series.Slices("123423453456", 2);
foreach (string s in test)
{
    Console.WriteLine(s);
}
Console.ReadLine();


public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (numbers.Length < sliceLength || sliceLength <= 0)
        {
            throw new ArgumentException($"Slice must be less than string length. {numbers.Length}");
        }

        try
        {

            string[] returnArray = new string[numbers.Length - (sliceLength - 1)];

            for (int i = 0; i < numbers.Length - (sliceLength - 1); i++)
            {
                string slice = $"{numbers.Substring(i, sliceLength)}";
                returnArray[i] = slice;
            }

            return returnArray;
        }
        catch(ArgumentException e)
        {
            Console.WriteLine(e.Message);
            return null;
        }
    }
}