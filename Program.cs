using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicate_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Write a program and ask the user to enter a few numbers separated by a hyphen.
            //If the user simply presses Enter, without supplying an input, exit immediately;
            //otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

            List<int> list = new List<int>();
            Console.WriteLine("Please enter numbers separated by '-'");
            string input = Console.ReadLine();
            if (input == null)
            {
                Environment.Exit(0);
            }
            var splitInput = input.Split('-');


            for (int i = 0; i < splitInput.Length; i++)
            {
                list.Add(int.Parse(splitInput[i]));

            }
            var index = 0;
            foreach (var number in list)
            {
                if (list.IndexOf(number) != index || list.LastIndexOf(number) != index)
                {
                    Console.WriteLine("duplicate");
                    break;
                }

                index = index + 1;
            }


        }
    }
}
