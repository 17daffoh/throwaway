using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace throwaway
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks how many pizzas the user wants
            Console.WriteLine("How many pizzas?");
            int answer = int.Parse(Console.ReadLine());

            for (int i = 0; i < answer; i++)  // Loops for the value of answer
            {
                Console.WriteLine("Eat pizza number " + (i+1));  // Counts up from one 
            }    
        }
    }
}
