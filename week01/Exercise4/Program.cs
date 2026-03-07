using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
      
      Console.WriteLine("Hello World! This is the Exercise4 Project.");

      int number = -1;
      int sum;
      int largest;
      List<int> numbers = new List<int>();
      
      while (number != 0)
      {
         
      
      int average;
      Console.Write("Enter number(0 to stop): ");
      string userNum = Console.ReadLine();
      number = int.Parse(userNum);
     

            if (number != 0)
            {
               numbers.Add(number);
            }
            Console.WriteLine("Numbers in list");

            sum = 0;
            foreach (int n in numbers)
            {
               Console.WriteLine(n);
               sum +=n;
            }

         Console.WriteLine($"Sum is: {sum}");
          int ave = numbers.Count;
       if(numbers.Count > 0)
         {
            average = sum / ave;
           Console.WriteLine($"Average is {average}");
         }
       largest = -1;
       foreach(int n in numbers)
         {
              if (n > largest )
              {
                largest = n;
              }
      
         }
     
      Console.WriteLine($"Largest:{largest}");
      }
      
      }
        
    }
