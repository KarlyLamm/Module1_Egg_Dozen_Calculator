using System;
using static System.Console;

namespace Module1_Challenge_Eggs
{
    class Eggs

    {
        static void Main(string[] args)
        {
            int chicken1_eggs = 0;
            int chicken2_eggs = 0;
            int chicken3_eggs = 0;
            int chicken4_eggs = 0;
            int total_eggs = 0;
            int dozen_amount = 0;
            int leftover_eggs = 0;

            Write("Enter eggs produced by chicken #1: ");
            chicken1_eggs = Convert.ToInt32(ReadLine());

            Write("Enter eggs produced by chicken #2: ");
            chicken2_eggs = Convert.ToInt32(ReadLine());

            Write("Enter eggs produced by chicken #3: ");
            chicken3_eggs = int.Parse(ReadLine());

            Write("Enter eggs produced by chicken #4: ");
            chicken4_eggs = int.Parse(ReadLine());

            total_eggs = chicken1_eggs + chicken2_eggs + chicken3_eggs + chicken4_eggs;

            //Calculate dozens
            dozen_amount = (total_eggs / 12);
            //Calculate leftover eggs
            leftover_eggs = total_eggs - (dozen_amount*12);
            //Display results
            WriteLine("There are {0} total eggs.", total_eggs);
            WriteLine("There are {0} dozen(s) and {1} leftover eggs", dozen_amount, leftover_eggs);


        }
    }
}
