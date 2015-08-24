using System;

class PrintLongSequence
{
    static void Main()
    {
        for (int i = 2; i < 1002; i++)
        {
            if (i % 2 == 0)   // Check if number is even then print positive
            {
                Console.Write(i + ",");
            }
            else             // If it is odd then print it negative
            {
                Console.Write(-i + ",");
            }
        }
        Console.Write("\b ");    // Remove the last comma :)
    }
}

