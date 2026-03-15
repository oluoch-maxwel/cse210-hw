using System;

class Program
{
    static void Main(string[] args)
    {
       Journal journal = new Journal();
       PromptGenerator promptGen = new  PromptGenerator();

       int choice = 0;

       while (choice != 5 )
       {
          Console.WriteLine("Journal Menu");
          Console.WriteLine(" 1. Write \n 2. Display\n 3. Save\n 4. Load\n 5. Quit");
          Console.Write("Enter your choice: ");
          choice = int.Parse(Console.ReadLine());

          if(choice == 1)
          {
              string prompt = promptGen.GenerateRandomPrompt();
              Console.WriteLine(prompt);

              string _response= Console.ReadLine();

              Entry entry = new Entry();

              entry._date = DateTime.Now.ToShortDateString();
              entry._promptText = prompt;
              entry._entryText = _response;

              journal.AddEntry(entry);
          }
          else if (choice == 2)
          {
              // Display entries
              journal.DisplayAll();
          }
          else if (choice == 3)
          {
              // Save journal
              Console.WriteLine("Enter filename:");
              string filename = Console.ReadLine();
              journal.SaveToFile(filename);
          }
          else if (choice == 4)
          {
              // Load journal
              Console.Write("Enter filename: ");
              string filename = Console.ReadLine();

              journal.LoadFromFile(filename);
          }
            else
            {
                // choice == 5 will exit the loop

              Console.WriteLine("Thank You for Your time");
                
            }
          
       }
    }
}