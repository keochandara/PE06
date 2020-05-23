using System;

namespace Comparestring
{
    class Stringcompare
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the first word that comes up on your mind: ");
            string userInput1 = Console.ReadLine();
            string UP1 = userInput1.ToLower();
            Console.WriteLine("Enter another word! : ");
            string userInput2 = Console.ReadLine();
            string UP2 = userInput2.ToUpper();

            Console.WriteLine("Comparing strings {0}", String.Compare(userInput1, userInput2, true) == 0 ? "true" : "false");
            
            
            Console.ReadLine();
        }
        
        
    }
}
