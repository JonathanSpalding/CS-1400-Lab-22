// Author: Jonathan Spalding
// Assignment: Lab 22
// Instructor Roger deBry
// Clas: CS 1400
// Date Written: 3/29/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
//----------------------------------------------------
using System;
using static System.Console;


namespace Using_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // State contstants and other variables used.
            int arrayTotal = 0;
            const int NUMBERS = 10;
            // create an array and assign a number size to it.
            int[] a1 = new int[NUMBERS];
            // for loop that runs ten times.
            for (var i = 0; i < NUMBERS; i++)
            {
                //WriteLine that asks to enter a number.
                WriteLine("Please type a number");
                // Assign each readLine to another index number in the Array.
                a1[i] = int.Parse(ReadLine());
            }
            // call back the AddArray method.
            AddArray(a1, arrayTotal);
            // ReadKey that keeps the window open until you press Enter.
            ReadKey(true);
        }
        // Create a Method for adding the array values.
        static void AddArray(int[] a1, int arrayTotal)
        {
            // For loop that runs as many times as there are values in the Array.
            for (var j = 0; j < a1.Length; j++)
            {
                // Add each value of the array together.
                arrayTotal = a1[j] + arrayTotal;
            }
            //writeline that displays the total sum.
            WriteLine($"The total of all those numbers you entered is {arrayTotal}.");
        }
    }
}
