/// <summary>
/// https://exercism.org/tracks/csharp/exercises/series
/// </summary>


Console.WriteLine(Series.Slices("123423453456", 2));
Console.ReadLine();


public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        string[] returnArray = new string[numbers.Length - (sliceLength - 1)];

        for (int i = 0; i < numbers.Length - (sliceLength - 1); i++)
        {
            string slice = $"{numbers.Substring(i, sliceLength)}";

        }

        return returnArray;
    }
}