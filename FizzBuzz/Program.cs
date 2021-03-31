using System;

namespace FizzBuzz
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int i = 0; i < 101; i++)
      {
        string fizzbuzz = "";
        if (i % 3 == 0 && i != 0)
        {
          fizzbuzz += "Fizz";
        }
        if (i % 5 == 0 && i != 0)
        {
          fizzbuzz += "Buzz";
        }
        Console.WriteLine($"{i} {fizzbuzz}");
      }
    }
  }
}
