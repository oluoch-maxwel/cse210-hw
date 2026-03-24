using System;

class Program
{
    static void Main(string[] args)
    {

         Reference reference = new Reference("John", 3, 23);
         Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his only begotten Son");

        while (true)
        {
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.AllHidden())
            {
                break;
            }
            
            Console.WriteLine("Press Enter to continue or Type 'quit'");
            scripture.HideRandomWords(3);
            string input = Console.ReadLine();
        

            if(input.ToLower()== "quit")
            {
                break;
            }
        }
        
    }
}