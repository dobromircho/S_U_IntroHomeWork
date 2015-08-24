using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.Write("Enter your birth date in format DD.MM.YYYY : "); // Ask for some data
        DateTime dateTime;   // Using DateTime Class which can hold date in proper format
        bool isDate = DateTime.TryParse(Console.ReadLine(), out dateTime); // Check if entry is valid date format
        if (isDate) // if it is valid then make some calculations
        {
            int years = dateTime.Year;    // Take only years from entry date as integer
            int age = DateTime.Now.Year - years; // Extract birth year from "now" year = age
            Console.WriteLine("Now : {0}", age);
            Console.WriteLine("After 10 years : {0}", age + 10);   // Print age and age + 10 
        }
        else
        {
            Console.WriteLine("Wrong Entry Or Format !!!"); // If entry data is not correct - print message
        }
        
    }
}

