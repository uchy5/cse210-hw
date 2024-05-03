using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int UserNumber = -1;
        while(UserNumber !=0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished.");
            string Response = Console.ReadLine();
            UserNumber = int.Parse(Response);

            if (UserNumber !=0)
            {
                numbers.Add(UserNumber);
            }
        }
    

        int Sum = 0;
        foreach (int number in numbers)
        {
            Sum += number;
        }
        Console.WriteLine($"the Sum is:{Sum}");

        float average = ((float)Sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}