using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder combinations = new StringBuilder();

        for (int i = 0; i < 10; i++)
        {
            for (int j = i + 1; j < 10; j++)
            {
                combinations.Append($"{i}{j}");

                if (!(i == 8 && j == 9)) 
                {
                    combinations.Append(", ");
                }
            }
        }

        Console.Write(combinations);
        Console.WriteLine(); 
    }
}
