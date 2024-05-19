using System;

class Program
{
    static void Main()
    {
        string[] inputArray = { "1234", "1567", "-2", "computer science" };
        
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        string[] resultArray = new string[count];
        int index = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                resultArray[index] = str;
                index++;
            }
        }

        Console.WriteLine("[" + string.Join(", ", resultArray) + "]");
    }
}