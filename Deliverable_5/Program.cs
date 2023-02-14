//Author: Thomas Overholt
//Date:2/13/2023
//Description: Application that uses methods to compute
//             random numbers to an array that is displayed

using System;
using System.Diagnostics.Metrics;


namespace Methods_Application
{
    class Program
    {
        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] Myarray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                Myarray[i] = random.Next(10,50);
            }
            return Myarray;
        }


        static int sum(int[] array)
        {
            int sum = 0;
            foreach(int item in array)
            {
                sum = sum + item;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integar between 5 and 15");

            int input = int.Parse(Console.ReadLine());

            try
            {
                if (input > 15 || input < 5)
                {
                    Console.WriteLine("Did not meet integar parameter.");
                }

                else 
                {
                    int[] sampleArray = random_array(input);

                    Console.WriteLine("The elements in the random array are: ");
                    foreach (int element in sampleArray)
                    {
                        Console.WriteLine(element + " ");
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("The sum is: " + sum(sampleArray));
                }
            }

            catch 
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}