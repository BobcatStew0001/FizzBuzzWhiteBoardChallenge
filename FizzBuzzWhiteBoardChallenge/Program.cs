// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public static string DivisibleBy(int n)
    {
        if(n % 3 == 0 && n % 5 == 0)
        {
            return "FizzBuzz"; 
        }
        else if(n % 3 == 0)
        {
            return "Fizz"; 
        }
        else if(n % 5 == 0)
        {
            return "Buzz";
        }
        else
        {
            return "This number is not divisible by 3 or 5.";
        }
    }
static void Main(string[] args)
{
    System.Console.WriteLine($"{DivisibleBy(15)}");
    System.Console.WriteLine($"{DivisibleBy(9)}");
    System.Console.WriteLine($"{DivisibleBy(10)}");
    System.Console.WriteLine($"{DivisibleBy(7)}");
}

        
}