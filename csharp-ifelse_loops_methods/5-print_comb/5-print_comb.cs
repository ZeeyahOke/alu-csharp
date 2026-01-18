using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder numbers = new StringBuilder();

        for (int i = 0; i < 100; i++)
        {
            numbers.Append(i.ToString("D2"));

            if (i < 99)
            {
                numbers.Append(", ");
            }
        }

        Console.Write(numbers);
        Console.WriteLine(); 
    }
}
